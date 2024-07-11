import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HaberlerComponent } from './haberler.component';

describe('HaberlerComponent', () => {
  let component: HaberlerComponent;
  let fixture: ComponentFixture<HaberlerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HaberlerComponent]
    });
    fixture = TestBed.createComponent(HaberlerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
