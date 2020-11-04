import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PhimListComponent } from './phim-list.component';

describe('PhimListComponent', () => {
  let component: PhimListComponent;
  let fixture: ComponentFixture<PhimListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PhimListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PhimListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
