import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { UsuarioService } from 'src/app/services/usuario.service';
import { Usuario } from '../../models/usuario';

@Component({
  selector: 'app-usuario-registro',
  templateUrl: './usuario-registro.component.html',
  styleUrls: ['./usuario-registro.component.css']
})
export class UsuarioRegistroComponent implements OnInit {
  formGroup: FormGroup;
  usuario: Usuario;

  constructor(private usuarioService: UsuarioService,private formBuilder: FormBuilder,private modalService:NgbModal) { }

  ngOnInit() {
    this.usuario=new Usuario();
        this.buildForm();
  }
  private buildForm() {
    this.usuario.IdUsuario='';
    this.usuario.Nombre='';
    this.usuario.Password='';
     this.formGroup = this.formBuilder.group({
      idUsuario: [this.usuario.IdUsuario, Validators.required],
      nombre: [this.usuario.Nombre, Validators.required],
      password: [this.usuario.Password, Validators.required],

    });
  }
  get control() { 
    return this.formGroup.controls;
     }
  onSubmit(){
    if (this.formGroup.invalid) {
            return;
          }
          this.add();
  }
  add() {
    this.usuario= this.formGroup.value;
    this.usuarioService.post(this.usuario).subscribe(p => {
      if (p != null) {
 
        const messageBox = this.modalService.open(AlertModalComponent);
        messageBox.componentInstance.title = 'Adivina...';
        messageBox.componentInstance.message = '(/*-*)/(/*-*)/(/*-*)/ --- Nuevo Usuario, registrado! --- (/*-*)/(/*-*)/(/*-*)/';
         
        this.usuario = p;
      }
    });

  }
}
