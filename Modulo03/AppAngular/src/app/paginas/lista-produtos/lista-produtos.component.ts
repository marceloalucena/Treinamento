import { Component, OnInit } from '@angular/core';
import { ProdutosService } from 'src/app/services/produtos.service';
import { Produto } from 'src/app/models/produto';

@Component({
  selector: 'MAL-lista-produtos',
  templateUrl: './lista-produtos.component.html'
})
export class ListaProdutosComponent implements OnInit {

  public listaProdutos: Produto[];
  constructor(private service: ProdutosService) { }

  ngOnInit() {
    this.service.obterProdutos().subscribe(prod => {
      this.listaProdutos = prod
      console.log(this.listaProdutos);
    },
      error => console.log(error)
    );
  }

  produtoSelecionado(prd: Produto){
    console.log('Clicou');
    prd.promocao = !prd.promocao;
  }

}
