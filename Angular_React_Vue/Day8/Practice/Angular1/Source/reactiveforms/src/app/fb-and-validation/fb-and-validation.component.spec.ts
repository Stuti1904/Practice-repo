import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FbAndValidationComponent } from './fb-and-validation.component';

describe('FbAndValidationComponent', () => {
  let component: FbAndValidationComponent;
  let fixture: ComponentFixture<FbAndValidationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FbAndValidationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FbAndValidationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
