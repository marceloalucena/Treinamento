import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './paginas/login/login.component';
import { NotFoundComponent } from './comum/not-found/not-found.component';


const routes: Routes = [
  { path: 'login', component: LoginComponent},
  {
    path: '', 
    loadChildren: ()=> import('./comum/layout/layout.module')
    .then(m => m.LayoutModule)
  },
  { path:'**', component: NotFoundComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
