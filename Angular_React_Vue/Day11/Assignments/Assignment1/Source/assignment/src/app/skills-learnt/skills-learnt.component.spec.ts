import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillsLearntComponent } from './skills-learnt.component';

describe('SkillsLearntComponent', () => {
  let component: SkillsLearntComponent;
  let fixture: ComponentFixture<SkillsLearntComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SkillsLearntComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SkillsLearntComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
