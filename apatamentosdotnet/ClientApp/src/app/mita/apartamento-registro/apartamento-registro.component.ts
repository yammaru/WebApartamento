import { Component, OnInit } from '@angular/core';
import { tick } from '@angular/core/testing';
import { FormBuilder, FormGroup,Validators, AbstractControl } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { ApartamentoService } from 'src/app/services/apartamento.service';
import { ArriendoService } from 'src/app/services/arriendo.service';
import { Apartamento } from '../models/apartamento';
import { Arriendo } from '../models/arriendo';

@Component({
  selector: 'app-apartamento-registro',
  templateUrl: './apartamento-registro.component.html',
  styleUrls: ['./apartamento-registro.component.css']
})
export class ApartamentoRegistroComponent implements OnInit {

  formGroup: FormGroup;
  apartamento: Apartamento;

  constructor(private apartamentoService: ApartamentoService,private formBuilder: FormBuilder,private modalService:NgbModal) { }
   ngOnInit() {this.apartamento=new Apartamento();
        this.buildForm();
      }
   
    private buildForm() {
      this.apartamento=new Apartamento();
      this.apartamento.idApartamento='';
      this.apartamento.valorApartamento=0;
      this.apartamento.deposito=0;
      this.apartamento.estado='';
       

          this.formGroup = this.formBuilder.group({
        idApartamento: [this.apartamento.idApartamento, Validators.required],
        valorApartamento: [ this.apartamento.valorApartamento, Validators.required],
        deposito: [this.apartamento.deposito,Validators.required],
        estado:[this.apartamento.estado,Validators.required]
            });
        }
      get control() { 
        return this.formGroup.controls;
         }
        
        onSubmit() {
              if (this.formGroup.invalid) {
                return;
              }
              this.add();
            }
          
  add() {
    this.apartamento = this.formGroup.value;

    this.apartamentoService.post(this.apartamento).subscribe(p => {
      if (p != null) {
 
        const messageBox = this.modalService.open(AlertModalComponent);
        messageBox.componentInstance.title = 'Adivina...';
        messageBox.componentInstance.message = '(/*-*)/(/*-*)/(/*-*)/ --- se a registrado un nuevo Apartamento! --- (/*-*)/(/*-*)/(/*-*)/';
         
        this.apartamento = p;
      }
    });

  }
}
