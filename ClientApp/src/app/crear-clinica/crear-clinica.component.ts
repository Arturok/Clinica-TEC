import { ClinicaService } from './../services/clinica.service';
import { Component, OnInit } from '@angular/core';
import { Clinica } from '../models/clinica';
import { Router } from '@angular/router';

@Component({
  selector: 'app-crear-clinica',
  templateUrl: './crear-clinica.component.html',
  styleUrls: ['./crear-clinica.component.css']
})
export class CrearClinicaComponent implements OnInit {
  clinica: Clinica = new Clinica();
  submitted = false;
  

  constructor(private clinicaService: ClinicaService, private router: Router) { }

  ngOnInit() {
  }
  nuevaClinica(): void {
    (this.submitted = false), (this.clinica = new Clinica());
  }

  save() {
    this.clinicaService.createClinica(this.clinica).subscribe(
      (data) => console.log(data),
      (error) => console.log(error)
    );
    this.clinica = new Clinica();
    this.goToMain();
  }

  onSubmit() {
    console.log(
      this.clinica.id,
      this.clinica.nombre,
      this.clinica.provincia,
      this.clinica.canton,
      this.clinica.distrito,
      this.clinica.otros,
      this.clinica.telefono,
      this.clinica.correo,
      this.clinica.sitioWeb,
      this.clinica.diaInicio,
      this.clinica.diaFinal,
      this.clinica.horaInicio,
      this.clinica.horaCierre,
      this.clinica.medicos,
      this.clinica.pacientes
    );
    var allOk = true;
    if (
      this.clinica.id == undefined ||
      this.clinica.nombre == undefined ||
      this.clinica.provincia == undefined ||
      this.clinica.canton == undefined ||
      this.clinica.distrito == undefined ||
      this.clinica.otros == undefined ||
      this.clinica.telefono == undefined ||
      this.clinica.correo == undefined ||
      this.clinica.sitioWeb == undefined ||
      this.clinica.diaInicio == undefined ||
      this.clinica.diaFinal == undefined ||
      this.clinica.horaInicio == undefined ||
      this.clinica.horaCierre == undefined
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
    this.router.navigate(['/clinicas'])
    .then(() => {
      window.location.reload();
    });
  }

}
