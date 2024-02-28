import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Contenedor } from 'src/app/helpers/contenedor';
import { Contenido } from 'src/app/helpers/contenido';
import { Empresa } from 'src/app/helpers/empresa';
import { Tickets } from 'src/app/helpers/tickets';
import { Unidad } from 'src/app/helpers/unidad';
import { ContenedoresService } from 'src/app/services/contenedores.service';
import { ContenidoService } from 'src/app/services/contenido.service';
import { EmpresaService } from 'src/app/services/empresa.service';
import { TicketsService } from 'src/app/services/tickets.service';
import { UnidadesService } from 'src/app/services/unidades.service';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.scss']
})
export class TicketComponent {
  id: number | undefined;
 
  public contenedor:Contenedor[] = [];
  public unidad:Unidad[] = [];
  public empresa:Empresa[] = [];
  public contenido: Contenido[] = [];
  ticket= new Tickets();

  formTicket: FormGroup;

  constructor(public activeModal: NgbActiveModal, private unidadService: UnidadesService,
    private contenedorService: ContenedoresService, private empresaService: EmpresaService,
    private contenidoService: ContenidoService, private ticketService: TicketsService,
    private formBuilder: FormBuilder) {
      this.formTicket = new FormGroup({
        empresa: new FormControl(''),
        cantidad: new FormControl(''),
        peso: new FormControl(''),
        tipoContenido: new FormControl(''),
        unidad: new FormControl(''),
        contenedor: new FormControl(''),
        viaje: new FormControl('')
      })
  }

  chargeSelect(){
    debugger;
    

    const unidadPromise = this.unidadService.get().toPromise();
    const contenedorPromise = this.contenedorService.get().toPromise();
    const empresaPromise = this.empresaService.get().toPromise();
    const contenidoPromise = this.contenidoService.get().toPromise();

    Promise.all([unidadPromise, contenedorPromise, empresaPromise, contenidoPromise]).then(
      (responses) => {
        this.empresa = responses[2];
        this.unidad = responses[0];

        this.contenedor = responses[1];
        this.contenido = responses[3];
        
        
      }
    );

  }

  ngOnInit(){
    this.chargeSelect();
    
  }

  onSave(){
    // this.ticketService.post(this.ticket).subscribe(
    //   (response) =>{
    //     console.log(response);
    //   },
    //   (error)=>{

    //   }
    // )
    alert("Hola ");
    console.log(this.formTicket.value);
  }

 

}
