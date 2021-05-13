import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ClienteService } from 'src/app/services/cliente.service';
import { Cliente } from '../../models/cliente';

@Component({
  selector: 'app-cliente-registro',
  templateUrl: './cliente-registro.component.html',
  styleUrls: ['./cliente-registro.component.css']
})
export class ClienteRegistroComponent implements OnInit {
cliente: Cliente;
  formGroup: FormGroup;

  constructor(private clienteService: ClienteService,private formBuilder: FormBuilder) { }
   ngOnInit() {
    this.cliente=new Cliente();
        this.buildForm();
      }
   
    private buildForm() {
      this.cliente=new Cliente();
      this.cliente.idCliente='';
      this.cliente.nombre='';
      this.cliente.telefono='';
       

          this.formGroup = this.formBuilder.group({
        idCliente: [this.cliente.idCliente, Validators.required],
        Nombre: [ this.cliente.nombre, Validators.required],
        telofono: [this.cliente.telefono,Validators.required],
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
    this.cliente = this.formGroup.value;

    this.clienteService.post(this.cliente).subscribe(p => {
      if (p != null) {
        alert('Registro Completado!');
        this.cliente = p;
      }
    });

  }

}
