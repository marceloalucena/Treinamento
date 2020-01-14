import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MenuComponent } from './comum/menu/menu.component';
import { FooterComponent } from './comum/footer/footer.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routers';
import { NotfoundComponent } from './comum/notfound/notfound.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    ListaProdutosComponent,
    ContatoComponent,
    NotfoundComponent
  ],
  imports: [
    BrowserModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
