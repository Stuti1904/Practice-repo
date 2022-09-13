import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MissionMangalComponent } from './mission-mangal.component';

describe('MissionMangalComponent', () => {
  let component: MissionMangalComponent;
  let fixture: ComponentFixture<MissionMangalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MissionMangalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MissionMangalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
