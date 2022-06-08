import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdithKennedyTynesComponent } from './edith-kennedy-tynes.component';

describe('EdithKennedyTynesComponent', () => {
  let component: EdithKennedyTynesComponent;
  let fixture: ComponentFixture<EdithKennedyTynesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EdithKennedyTynesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EdithKennedyTynesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
