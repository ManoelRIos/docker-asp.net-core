import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-pedidos',
  templateUrl: './card-pedidos.component.html',
  styleUrls: ['./card-pedidos.component.scss']
})
export class CardPedidosComponent implements OnInit {

  @Input() title: string = "Pendente";


  constructor() { }

  ngOnInit() {
  }

}
