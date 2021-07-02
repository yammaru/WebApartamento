import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { ArriendoService } from 'src/app/services/arriendo.service';
import { Arriendo } from '../../models/arriendo';

@Component({
  selector: 'app-arriendo-consulta',
  templateUrl: './arriendo-consulta.component.html',
  styleUrls: ['./arriendo-consulta.component.css']
})
export class ArriendoConsultaComponent implements OnInit {
  arriendos: Arriendo[];
  searchText: string;
  arriendo:Arriendo;
  constructor(private arriendoService: ArriendoService,private modalService: NgbModal) { }

  ngOnInit() {
    this.arriendoService.get().subscribe(result => {
      this.arriendos = result; 
     });
  }
  ubica(s: string){  
 
   //this.arriendoService.eliminar(s).subscribe();
   
   const messageBox = this.modalService.open(AlertModalComponent);
   messageBox.componentInstance.title = 'Adivina...';
   messageBox.componentInstance.message = '(/*-*)/(/*-*)/(/*-*)/ --- se elimino! --- (/*-*)/(/*-*)/(/*-*)/';
    
   
   this.ngOnInit();
   }
}
