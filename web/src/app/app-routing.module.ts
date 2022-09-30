import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { EstoqueComponent } from './pages/estoque/estoque.component';
import { PedidosComponent } from './pages/pedidos/pedidos.component';

const routes: Routes = [
  { path: '', redirectTo: 'pedidos', pathMatch: 'full'},
  { path: 'cardapio', component: CardapioComponent},
  { path: 'pedidos', component: PedidosComponent},  
  { path: 'estoque', component: EstoqueComponent},  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
