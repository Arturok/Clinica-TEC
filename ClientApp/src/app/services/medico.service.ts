import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  constructor(private httpClient: HttpClient) { }

  getMedicos(){
    return this.httpClient.get('/api/medicos');
  }

  createMedico(medico: Object): Observable<Object> {
    return this.httpClient.post('/api/medicos', medico);
  }
  deleteMedico(id: string) {
    return this.httpClient.delete('/api/medicos/'+id);
  }
}
