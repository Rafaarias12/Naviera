import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Tickets } from '../helpers/tickets';
import { Itickets } from '../helpers/itickets';

const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class TicketsService {
  url: string = "https://localhost:7078/api/ticket";
  constructor(private http: HttpClient) {}
  


  post(ticket:Tickets): Observable<any> {
    
    return this.http.post(this.url, ticket, httpOption);
  }

}
