import { ClinicaService } from './../services/clinica.service';
import { Component, OnInit } from '@angular/core';
import { Clinica } from '../models/clinica';

@Component({
  selector: 'app-clinicas',
  templateUrl: './clinicas.component.html',
  styleUrls: ['./clinicas.component.css']
})
export class ClinicasComponent implements OnInit {
  clinicas;

  constructor(private clinicaService: ClinicaService) { } 

  ngOnInit(): void {
    this.clinicaService.getClinicas().subscribe(clinicas => {
      this.clinicas = clinicas;
      console.log("Clinicas: ", this.clinicas);
    });
  }
}
