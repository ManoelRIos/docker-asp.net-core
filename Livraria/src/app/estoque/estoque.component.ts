import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-estoque',
  templateUrl: './estoque.component.html',
  styleUrls: ['./estoque.component.scss']
})
export class EstoqueComponent implements OnInit {
  public titulo = 'Estoque';

  public produtos = [
    { id:1, nome:'Batata', qtd: 3, undMed:'Kg'},
    { id:2, nome:'Alface', qtd: 6, undMed:'Und'},
    { id:3, nome:'Cenoura', qtd: 9, undMed:'Und'},
    { id:4, nome:'Burguer', qtd: 12, undMed:'Kg'},
    { id:5, nome:'Coca-cola', qtd: 15, undMed:'L'},
    { id:6, nome:'Guaraná', qtd: 18, undMed: 'L'}
  ];

  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];


  constructor() { }

  ngOnInit() {
  }

}
