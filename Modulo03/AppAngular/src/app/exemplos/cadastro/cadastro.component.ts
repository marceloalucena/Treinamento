import { Component, OnInit, AfterViewInit, ViewChildren, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl, FormControlName } from '@angular/forms';
import { NgBrazilValidators } from 'ng-brazil';
import { utilsBr } from 'js-brasil';
import { CustomValidators } from 'ng2-validation';
import { GenericValidator, DisplayMessage, ValidationMessages } from 'src/app/generic-validator';
import { Observable, fromEvent, merge } from 'rxjs';

@Component({
  selector: 'MAL-cadastro',
  templateUrl: './cadastro.component.html',
  styles: []
})
export class CadastroComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef}) formInputElements: ElementRef[];
  
  public MASKS = utilsBr.MASKS;
  cadastroForm: FormGroup;
  genericValidator: GenericValidator;
  displayMessage: DisplayMessage = {};
  validationMessages : ValidationMessages;
  alteracoesPendentes: boolean;

  constructor(private fb: FormBuilder) {
    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido',
        rangeLength: 'A senha deve possuir entre 3 e 10 caracteres',
        minlength: 'O Nome precisa ter no mínimo 2 caracteres',
        maxlength: 'O Nome precisa ter no máximo 60 caracteres'
      },
      cpf: {
        required: 'Informe o CPF',
        cpf: 'CPF em formato inválido'
      },
      email: {
        required: 'Informe o e-mail',
        email: 'Email inválido'
      },
      senha: {
        required: 'Informe a senha',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres'
      },
      confirmacaoSenha: {
        required: 'Informe a senha novamente',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres',
        equalTo: 'As senhas não conferem'
      }
    };

    this.genericValidator = new GenericValidator(this.validationMessages);      
  }

  ngOnInit() {
    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 10])]);
    let confirmacaoSenha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 10]), CustomValidators.equalTo(senha)
       ]);
    
    this.cadastroForm = this.fb.group({
      nome: ['', [Validators.required,CustomValidators.rangeLength([3, 10]) ]],
      email: ['', [Validators.required, Validators.email]],
      cpf: ['', [Validators.required, NgBrazilValidators.cpf]],
      senha: senha,
      confirmacaoSenha: confirmacaoSenha
   });
   

  }

  ngAfterViewInit(): void {
    let ControlBlurs: Observable<any>[] = this.formInputElements
        .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge( ... ControlBlurs).subscribe(() => {
      this.displayMessage = this.genericValidator.processarMensagens(this.cadastroForm);
      this.alteracoesPendentes = true;
    })
  }

  salvar(){
     this.alteracoesPendentes = false;
  }
}
