import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.scss']
})
export class CardapioComponent implements OnInit {

  title = 'Cardápio';

  public pratos = [
    { nome:'Batata'},
    { nome:'Hambúrguer'},
    { nome:'Coca-cola'},
    { nome:'Guaraná'},
    { nome:'Coxinha'}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
