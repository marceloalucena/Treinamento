import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { CadastroComponent } from './cadastro.component';

@Injectable()

export class CadastroGuardService implements CanDeactivate<CadastroComponent>{

  canDeactivate(component: CadastroComponent): boolean
  {
    if (component.alteracoesPendentes)
      return window.confirm("Deseja abandonar o preenchimento do ponto e virgula?");
      
    return false;
  }

  constructor() { }
}
