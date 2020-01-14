import { Routes } from '@angular/router';
import { ContatoComponent } from './paginas/contato/contato.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { NotfoundComponent } from './comum/notfound/notfound.component';

export const rootRouterConfig: Routes = [
    {path:'', redirectTo: '/produtos', pathMatch: 'full'},
    {path:'contato', component:ContatoComponent},
    {path:'produtos', component:ListaProdutosComponent},
    {path:'**', component:NotfoundComponent}
];