import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class EmpresaService {

  constructor(private httpClient: HttpClient) { }
  url = "https://localhost:7078/api/ticket/Empresa";
  get(): Observable<any> {
    return this.httpClient.get<any>(this.url, httpOption);
  }
}
