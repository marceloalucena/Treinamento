import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Produto } from '../models/produto';

@Injectable()
export class ProdutosService {

  protected urlApi: string = "http://localhost:3000/produtos"
  constructor(private http: HttpClient) { }

  obterProdutos(): Observable<Produto[]>{
    return this.http.get<Produto[]>(this.urlApi);
  }
  obterProduto(id: number): Observable<Produto>{
    return this.http.get<Produto>(`${this.urlApi}/${id}`);
  }
}
