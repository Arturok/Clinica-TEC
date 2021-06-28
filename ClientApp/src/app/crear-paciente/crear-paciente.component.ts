import { EstadosService } from './../services/estados.service';
import { Router } from '@angular/router';
import { PacienteService } from './../services/paciente.service';
import { Paciente } from './../models/paciente';
import { Component, OnInit } from '@angular/core';
import { Estado } from '../models/estado';

@Component({
  selector: 'app-crear-paciente',
  templateUrl: './crear-paciente.component.html',
  styleUrls: ['./crear-paciente.component.css']
})
export class CrearPacienteComponent implements OnInit {
  paciente: Paciente = new Paciente();
  submitted = false;
  estados;
  
  constructor(private pacienteService: PacienteService, private estadosService: EstadosService, private router: Router) { }

  ngOnInit() {
    this.estadosService.getEstados().subscribe(estados => {
      this.estados = estados;
      console.log("Estados: ", this.estados);
    });
  }

  nuevoPaciente(): void {
    (this.submitted = false), (this.paciente = new Paciente());
  }

  save() {
    this.pacienteService.createPaciente(this.paciente).subscribe(
      (data) => console.log(data),
      (error) => console.log(error)
    );
    this.paciente = new Paciente();
    this.goToMain();
  }
  
  onSubmit() {
    console.log(
      this.paciente.id,
      this.paciente.nombre,
      this.paciente.apellido1,
      this.paciente.apellido2,
      this.paciente.provincia,
      this.paciente.canton,
      this.paciente.distrito,
      this.paciente.otros,
      this.paciente.correo,
      this.paciente.fechaNacimiento,
      this.paciente.tipoSangre,
      this.paciente.estadoId
    );
    var allOk = true;
    if (
      this.paciente.id == undefined ||
      this.paciente.nombre == undefined ||
      this.paciente.apellido1 == undefined ||
      this.paciente.apellido2 == undefined ||
      this.paciente.provincia == undefined ||
      this.paciente.canton == undefined ||
      this.paciente.distrito == undefined ||
      this.paciente.otros == undefined ||
      this.paciente.correo == undefined ||
      this.paciente.fechaNacimiento == undefined ||
      this.paciente.tipoSangre == undefined ||
      this.paciente.estadoId == undefined
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
    this.router.navigate(['/pacientes'])
    .then(() => {
      window.location.reload();
    });
  }

}
