import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ClinicaService {

  constructor(private httpClient: HttpClient) { }

  getClinicas(){
    return this.httpClient.get('/api/clinicas');
  }
}
