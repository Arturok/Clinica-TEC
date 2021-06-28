import { PacienteService } from './../services/paciente.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pacientes',
  templateUrl: './pacientes.component.html',
  styleUrls: ['./pacientes.component.css']
})
export class PacientesComponent implements OnInit {
  pacientes;

  constructor(private pacienteServise: PacienteService) { }

  ngOnInit() {
    this.pacienteServise.getPacientes().subscribe(pacientes => {
      this.pacientes = pacientes;
      console.log("Pacientes: ", this.pacientes);
    })
  }
  delete(id: string) {
    console.log("ID: ", id);
    this.pacienteServise.deletePaciente(id).subscribe(
      (data) => console.log(data),
      (error) => console.log(error)
    );
    window.location.reload();
  }

}
