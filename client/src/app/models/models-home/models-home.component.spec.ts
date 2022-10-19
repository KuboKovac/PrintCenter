import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModelsHomeComponent } from './models-home.component';

describe('ModelsHomeComponent', () => {
  let component: ModelsHomeComponent;
  let fixture: ComponentFixture<ModelsHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModelsHomeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModelsHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
