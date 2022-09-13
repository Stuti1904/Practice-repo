import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PacificPathComponent } from './pacific-path.component';

describe('PacificPathComponent', () => {
  let component: PacificPathComponent;
  let fixture: ComponentFixture<PacificPathComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PacificPathComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PacificPathComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
