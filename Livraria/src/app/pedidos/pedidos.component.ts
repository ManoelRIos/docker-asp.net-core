import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.scss']
})
export class PedidosComponent implements OnInit {

  title = 'Pedidos';

  public pedidos = [
    {nome: 'Batata'},
    {nome: 'Hambúrguer'},
    {nome: 'Coca-cola'},
    {nome: 'Guaraná'},
    {nome: 'Coxinha'}

  ]

  constructor() { }

  ngOnInit(): void {
  }

}
