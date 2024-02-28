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
export class UserService {

  url: string = "https://localhost:7078/api/usuarios/login";
  constructor(private http: HttpClient) {}

  login(User: string, Password: string): Observable<any> {
    
    return this.http.post(this.url, {User, Password}, httpOption);
  }



}
