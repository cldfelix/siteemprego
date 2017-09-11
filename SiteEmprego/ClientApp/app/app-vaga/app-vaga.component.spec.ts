import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppVagaComponent } from './app-vaga.component';

describe('AppVagaComponent', () => {
  let component: AppVagaComponent;
  let fixture: ComponentFixture<AppVagaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppVagaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppVagaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
