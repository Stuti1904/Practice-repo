import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtlanticPathComponent } from './atlantic-path.component';

describe('AtlanticPathComponent', () => {
  let component: AtlanticPathComponent;
  let fixture: ComponentFixture<AtlanticPathComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AtlanticPathComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AtlanticPathComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
