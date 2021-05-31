import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ArriendoService } from 'src/app/services/arriendo.service';
import { Apartamento } from '../../models/apartamento';
import { Arriendo } from '../../models/arriendo';
import { ApartamentoService } from 'src/app/services/apartamento.service';
@Component({
  selector: 'app-arriendo-registro',
  templateUrl: './arriendo-registro.component.html',
  styleUrls: ['./arriendo-registro.component.css']
})
export class ArriendoRegistroComponent implements OnInit {
  mita: Arriendo;
  formGroup: FormGroup;
  apartamento: Apartamento;
  apartamentos:Apartamento[];
  mitaApartamentos: any;
  constructor(private arriendoService: ArriendoService, private apartamentoService: ApartamentoService,private formBuilder: FormBuilder) { }
   ngOnInit() {this.mita=new Arriendo();
        this.buildForm();this.busca();
      }
    busca(){ 
      this.apartamentoService.get().subscribe(result => {
      this.apartamentos = result;
      });
    }
  onChange() {  console.log(this.apartamento); 
    let apartamento = this.control.idArriendo.value;
 
   this.buscaApartamento(apartamento);
    
  }
  buscaApartamento(id:string){
    this.mitaApartamentos= this.apartamentoService.buscar(id);
  console.log(this.mitaApartamentos);debugger
  }
    private buildForm() {
          this.mita = new Arriendo();
          this.mita.idArriendo = '';
           this.mita.fechaDesalojo ;
          this.mita.idCliente='';
          this.mita.fechaIngreso ;

          this.formGroup = this.formBuilder.group({
        idArriendo: [this.mita.idArriendo, Validators.required],
        idCliente: [ this.mita.idCliente, Validators.required],
        idarriendo: [this.mita.idArriendo,Validators.required],
        arriendo:[],
        deposito:[],
        nombre:[],
        telefono:[],
        fechaIngreso:[this.mita.fechaIngreso,Validators.required]
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
    this.mita = this.formGroup.value;

    this.arriendoService.post(this.mita).subscribe(p => {
      if (p != null) {
        alert('Registro Completado!');
        this.mita = p;
      }
    });

  }
}
