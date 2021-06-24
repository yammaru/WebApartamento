import { Component, OnInit, ɵɵqueryRefresh } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { ApartamentoService } from 'src/app/services/apartamento.service';
import { Apartamento } from '../models/apartamento';

@Component({
  selector: 'app-apartamento-consulta',
  templateUrl: './apartamento-consulta.component.html',
  styleUrls: ['./apartamento-consulta.component.css']
})
export class ApartamentoConsultaComponent implements OnInit {
  personas: Apartamento[];
  apartamento: Apartamento;
  mensaje:any;
  searchText:string;
  constructor(private apartamentoService: ApartamentoService,private modalService: NgbModal) { }

  ngOnInit(){
    this.apartamentoService.get().subscribe(result => {
      this.personas = result;
      });
  }
  ubica(s: string){
   /* this.apartamentoService.buscar(s).subscribe(result=>{ 
     this.apartamento=result;
    if(this.apartamento!=null){
      console.log(this.apartamento);
    }
    });*/
    

  this.apartamentoService.eliminar(s).subscribe();
  
  const messageBox = this.modalService.open(AlertModalComponent);
  messageBox.componentInstance.title = 'Adivina...';
  messageBox.componentInstance.message = '(/*-*)/(/*-*)/(/*-*)/ --- se elimino! --- (/*-*)/(/*-*)/(/*-*)/';
   
  
  this.ngOnInit();
  }
}
