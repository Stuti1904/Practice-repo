import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentDummyComponent } from './component-dummy.component';

describe('ComponentDummyComponent', () => {
  let component: ComponentDummyComponent;
  let fixture: ComponentFixture<ComponentDummyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComponentDummyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComponentDummyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
