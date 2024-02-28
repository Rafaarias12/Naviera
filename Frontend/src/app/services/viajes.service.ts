import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ViajesService {

  constructor(private httpClient: HttpClient) { }

  url: string = "https://localhost:7078/api/viajes";

  get():Observable<any>{
    return this.httpClient.get<any>(this.url, httpOption);
  }
}
