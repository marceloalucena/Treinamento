import { Component, OnInit } from '@angular/core';
import { ProdutosService } from 'src/app/services/produtos.service';
import { Produto } from 'src/app/models/produto';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'MAL-visualizar-produto',
  templateUrl: './visualizar-produto.component.html'
})
export class VisualizarProdutoComponent implements OnInit {

  modelo: Produto;

  constructor
  (
    private service: ProdutosService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit() {
    let id = this.route.snapshot.params['id'];
    this.service.obterProduto(id).subscribe(result => {this.modelo = result});
    console.log(this.modelo);
  }

  Voltar(){
     this.router.navigate(['produtos'])
  }

}
