import { MedicoService } from './../services/medico.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-medicos',
  templateUrl: './medicos.component.html',
  styleUrls: ['./medicos.component.css']
})
export class MedicosComponent implements OnInit {
  medicos;

  constructor(private medicoService: MedicoService) { }

  ngOnInit() {
    this.medicoService.getMedicos().subscribe(medicos => {
      this.medicos = medicos;
      console.log("Medicos: ", this.medicos);
    });
  }
  delete(id: string) {
    console.log("ID: ", id);
    this.medicoService.deleteMedico(id).subscribe(
      (data) => console.log(data),
      (error) => console.log(error)
    );
    window.location.reload();
  }

}
