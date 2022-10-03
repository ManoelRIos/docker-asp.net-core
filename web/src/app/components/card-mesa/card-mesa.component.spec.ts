/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CardMesaComponent } from './card-mesa.component';

describe('CardMesaComponent', () => {
  let component: CardMesaComponent;
  let fixture: ComponentFixture<CardMesaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CardMesaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CardMesaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
