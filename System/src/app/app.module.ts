import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PedidosComponent } from './pedidos/pedidos.component';
import { CardapioComponent } from './cardapio/cardapio.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MenuComponent } from './menu/menu.component';
import { LayoutModule } from '@angular/cdk/layout';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MaterialModule } from '../material.module';
import { TitleComponent } from './title/title.component';
import { EstoqueComponent } from './estoque/estoque.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { UserAccountComponent } from './userAccount/userAccount.component';
import { ModalModule } from 'ngx-bootstrap/modal';





@NgModule({
  declarations: [			
    AppComponent,
    PedidosComponent,
    CardapioComponent,
    MenuComponent,
    DashboardComponent,
      TitleComponent,
      EstoqueComponent,
      UserAccountComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    MaterialModule,
    BsDropdownModule.forRoot(),
    FormsModule,
    ReactiveFormsModule,
    ModalModule.forRoot(),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
