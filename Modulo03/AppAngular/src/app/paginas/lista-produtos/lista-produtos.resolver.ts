import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Produto } from 'src/app/models/produto';
import { ProdutosService } from 'src/app/services/produtos.service';

@Injectable()

export class ListaProdutosResolver implements Resolve<Observable<Produto[]>> {
    
    constructor(private service: ProdutosService){}

    resolve(route: ActivatedRouteSnapshot) 
    {
        return this.service.obterProdutos();
    }
}


