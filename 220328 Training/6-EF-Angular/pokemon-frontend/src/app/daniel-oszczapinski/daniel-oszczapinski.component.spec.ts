import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanielOszczapinskiComponent } from './daniel-oszczapinski.component';

describe('DanielOszczapinskiComponent', () => {
  let component: DanielOszczapinskiComponent;
  let fixture: ComponentFixture<DanielOszczapinskiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanielOszczapinskiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DanielOszczapinskiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
