import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EtkinliklerComponent } from './etkinlikler.component';

describe('EtkinliklerComponent', () => {
  let component: EtkinliklerComponent;
  let fixture: ComponentFixture<EtkinliklerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EtkinliklerComponent]
    });
    fixture = TestBed.createComponent(EtkinliklerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
