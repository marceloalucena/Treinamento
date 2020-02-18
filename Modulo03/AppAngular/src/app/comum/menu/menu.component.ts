import { Component, OnInit } from '@angular/core';
import { Navegacao } from './navegacao';

@Component({
  selector: 'MAL-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {
  
  Menu: Navegacao[] = [];
   
  constructor() { }

  ngOnInit() {
    this.Menu.push({descricao: 'Cadastro', icone: 'fa fa-address-card-o', link: '/cadastro'});
    this.Menu.push({descricao: 'DataBinding', icone: 'fa fa-database', link: '/data-binding'});
    this.Menu.push({descricao: 'Produtos', icone: 'fa fa-product-hunt', link: '/produtos'});
    this.Menu.push({descricao: 'Contato', icone: 'fa fa-bullhorn', link: '/contato'});
    this.Menu.push({descricao: 'Admin', icone: 'fa fa-cogs', link: '/admin'});
  }

}
