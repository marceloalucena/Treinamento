import { Routes, RouterModule } from '@angular/router';
import { ContatoComponent } from './paginas/contato/contato.component';
import { NotfoundComponent } from './comum/notfound/notfound.component';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';
import { NgModule } from '@angular/core';
import { AuthGuardService } from './services/auth-guard.service';
import { CadastroGuardService } from './exemplos/cadastro/cadastro-guard.service';

const rootRouterConfig: Routes = [
    {path:'', redirectTo: '/home', pathMatch: 'full'},
    {path:'home', component:HomeComponent},
    {path:'contato', component:ContatoComponent},
    {path:'produtos', loadChildren:()=> import('./paginas/lista-produtos/lista-produtos.module').then(m => m.ListaProdutosModule)},
    {path:'admin', 
        loadChildren:()=> import('./paginas/admin/admin.module')
        .then(m => m.AdminModule),
        canLoad:[AuthGuardService],
        canActivate:[AuthGuardService]},
    {path:'data-binding', component:DataBindingComponent},
    {path:'cadastro', component:CadastroComponent, canDeactivate: [CadastroGuardService]},
    {path:'**', component:NotfoundComponent}
];

@NgModule({
    imports: [
        RouterModule.forRoot(rootRouterConfig, {enableTracing: true})
    ],
    exports: [        
        RouterModule
    ]
})

export class AppRoutingModule { }