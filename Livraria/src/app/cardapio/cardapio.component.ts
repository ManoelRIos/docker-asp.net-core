import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.scss']
})
export class CardapioComponent implements OnInit {

  public title = 'Cardápio';

  pratoSelected!: string;

  public pratos = [
    { id:1, nome:'Batata', desc: 'Batata com cheddar e bacon', valor: 35},
    { id:2, nome:'Hambúrguer', desc: 'Burguer caseiro de 260g com molho da casa', valor: 60.99},
    { id:3, nome:'Coca-cola', desc: 'coca-gelada na hora com gelo seco', valor: 35},
    { id:4, nome:'Guaraná', desc: 'guaraná natu',valor: 3.50 },
    { id:5, nome:'Coxinha', desc: 'coxinha de frango feita no óleo de ontem', valor: 6 }
  ];

  pratoSelect(prato: any){
    this.pratoSelected = prato.nome;
  }

  voltar(){
    this.pratoSelected = '';
  }

  constructor() { }

  ngOnInit(): void {
  }

}
