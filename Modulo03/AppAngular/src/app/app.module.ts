import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { AppRoutingModule } from './app.routers';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { HttpClientModule } from '@angular/common/http';
import localePt from '@angular/common/locales/pt';
import { registerLocaleData } from '@angular/common';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';
registerLocaleData(localePt);
import { NgBrazil } from 'ng-brazil';
import { TextMaskModule } from 'angular2-text-mask';
import { CustomFormsModule } from 'ng2-validation';
import { ComumModule } from './comum/comum.module';
import { ListaProdutosModule } from './paginas/lista-produtos/lista-produtos.module';
import { AuthGuardService } from './services/auth-guard.service';
import { CadastroGuardService } from './exemplos/cadastro/cadastro-guard.service';

@NgModule({
  declarations: [
    AppComponent,
    ContatoComponent,
    HomeComponent,
    DataBindingComponent,
    CadastroComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,

    ComumModule,
    ListaProdutosModule,

    ReactiveFormsModule,
    TextMaskModule,
    NgBrazil,
    CustomFormsModule,
    AppRoutingModule
  ],
  providers: [AuthGuardService, CadastroGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
