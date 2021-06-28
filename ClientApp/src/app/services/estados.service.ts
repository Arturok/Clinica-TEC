import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EstadosService {

  constructor(private httpClient: HttpClient) { }

  getEstados() {
    return this.httpClient.get('/api/estados');
  }
}
