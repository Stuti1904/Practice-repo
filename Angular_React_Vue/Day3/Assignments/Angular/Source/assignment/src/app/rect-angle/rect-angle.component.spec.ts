import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RectAngleComponent } from './rect-angle.component';

describe('RectAngleComponent', () => {
  let component: RectAngleComponent;
  let fixture: ComponentFixture<RectAngleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RectAngleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RectAngleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
