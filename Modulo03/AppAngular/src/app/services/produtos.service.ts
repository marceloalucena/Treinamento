import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Produto } from '../models/produto';
import { environment } from 'src/environments/environment';

@Injectable()
export class ProdutosService {

  protected urlApi: string = environment.urlAPI_Produto;
  constructor(private http: HttpClient) { }

  obterProdutos(): Observable<Produto[]>{
    return this.http.get<Produto[]>(this.urlApi);
  }
  obterProduto(id: number): Observable<Produto>{
    return this.http.get<Produto>(`${this.urlApi}/${id}`);
  }
}
