import { map } from 'rxjs/operators';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Produto } from '../models/Produto';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-estoque',
  templateUrl: './estoque.component.html',
  styleUrls: ['./estoque.component.scss']
})
export class EstoqueComponent implements OnInit {

  public modalRef?: BsModalRef;
  public produtoForm!: FormGroup;
  public titulo = 'Estoque';
  textSimple?: string;

  public produtoSelected?: null | Produto;

  public produtos = [
    { id:1, nome:'Batata', qtd: 3, undMed:'Kg'},
    { id:2, nome:'Alface', qtd: 6, undMed:'Und'},
    { id:3, nome:'Cenoura', qtd: 9, undMed:'Und'},
    { id:4, nome:'Burguer', qtd: 12, undMed:'Kg'},
    { id:5, nome:'Coca-cola', qtd: 15, undMed:'L'},
    { id:6, nome:'Guaraná', qtd: 18, undMed: 'L'}
  ];
  
 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder,
              private modalService: BsModalService) { 
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.produtoForm = this.fb.group({
      nome: ['', Validators.required],
      qtd: ['', Validators.required],
      undMed: ['', Validators.required]
    });
  }
  produtoSubmit(){
    console.log(this.produtoForm.value);
    
  }

  produtoSelect(produto: Produto){
    this.produtoSelected = produto;
    this.produtoForm.patchValue(produto);
  }

  addQtd(produto: Produto){
    produto.qtd++;    
  }

  removeQtd(produto: Produto){
    produto.qtd--;    
  }


  voltar(){
    this.produtoSelected = null;
  }
}
