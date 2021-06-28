import { MedicoService } from './../services/medico.service';
import { Component, OnInit } from '@angular/core';
import { Medico } from '../models/medico';
import { Router } from '@angular/router';

@Component({
  selector: 'app-crear-medico',
  templateUrl: './crear-medico.component.html',
  styleUrls: ['./crear-medico.component.css']
})
export class CrearMedicoComponent implements OnInit {
  medico:Medico = new Medico();
  submitted = false;

  constructor(private medicoService: MedicoService, private router: Router) { }

  ngOnInit() {
  }

  nuevoMedico(): void {
    (this.submitted = false), (this.medico = new Medico());
  }  

  save() {
    this.medicoService.createMedico(this.medico).subscribe(
      (data) => console.log(data),
      (error) => console.log(error)
    );
    this.medico = new Medico();
    this.goToMain();
  }

  onSubmit() {
    console.log(
      this.medico.id,
      this.medico.cedula,
      this.medico.nombre,
      this.medico.apellido1,
      this.medico.apellido2,
      this.medico.especialidad,
      this.medico.estado,
    );
    var allOk = true;
    if (
      this.medico.id == undefined ||
      this.medico.cedula == undefined ||
      this.medico.nombre == undefined ||
      this.medico.apellido1 == undefined ||
      this.medico.apellido2 == undefined ||
      this.medico.especialidad == undefined ||
      this.medico.estado == undefined
    ) {
      allOk = false;
      alert("Llene todos los campos requeridos");
    } else {
      allOk = true;
    }

    if (allOk) {
      this.submitted = true;
      this.save();
    }
  }

  goToMain() {
    this.router.navigate(['/medicos'])
    .then(() => {
      window.location.reload();
    });
  }

}
