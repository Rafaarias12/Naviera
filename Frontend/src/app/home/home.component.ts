import { Component } from '@angular/core';
import { ViajesService } from '../services/viajes.service';
import Swal from 'sweetalert2';
import { Viaje } from '../helpers/viaje';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { TicketComponent } from '../componentes/ticket/ticket.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  
  constructor(private viajesService: ViajesService, private modalService: NgbModal) {
    
  }

  public lst: any;
  public datos: Viaje[] = [];

  ngOnInit(){
    this.cargaViajes();
  }

  cargaViajes(){
    this.viajesService.get().subscribe(
      (response)=>{
        

        this.datos = response;
        console.log(this.datos);
      },
      (error) => {
        Swal.fire({
          icon: "error",
          title: "Oops...",
          text: "No hay datos..."
        });
      }
      
    )
  }

  ticket(id: number){
    const modal = this.modalService.open(TicketComponent);
    modal.componentInstance.id = id;
  }

}
