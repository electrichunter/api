import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FirmalarComponent } from './firmalar.component';

describe('FirmalarComponent', () => {
  let component: FirmalarComponent;
  let fixture: ComponentFixture<FirmalarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FirmalarComponent]
    });
    fixture = TestBed.createComponent(FirmalarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
