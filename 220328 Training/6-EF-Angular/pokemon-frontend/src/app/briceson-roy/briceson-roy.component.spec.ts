import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BricesonRoyComponent } from './briceson-roy.component';

describe('BricesonRoyComponent', () => {
  let component: BricesonRoyComponent;
  let fixture: ComponentFixture<BricesonRoyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BricesonRoyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BricesonRoyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
