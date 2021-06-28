import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PacienteService {

  constructor(private httpClient: HttpClient) { }
  getPacientes(){
    return this.httpClient.get('/api/pacientes');
  }

  createPaciente(paciente: Object): Observable<Object> {
    return this.httpClient.post('/api/pacientes', paciente);
  }
}
