import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/models/produto';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'MAL-lista-produtos',
  templateUrl: './lista-produtos.component.html'
})
export class ListaProdutosComponent implements OnInit {

  public listaProdutos: Produto[];

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.listaProdutos = this.route.snapshot.data['produtos'];
  }

  produtoSelecionado(prd: Produto){
    console.log('Clicou');
    prd.promocao = !prd.promocao;
  }

}
