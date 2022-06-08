import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VladimirShnyakinComponent } from './vladimir-shnyakin.component';

describe('VladimirShnyakinComponent', () => {
  let component: VladimirShnyakinComponent;
  let fixture: ComponentFixture<VladimirShnyakinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VladimirShnyakinComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VladimirShnyakinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
