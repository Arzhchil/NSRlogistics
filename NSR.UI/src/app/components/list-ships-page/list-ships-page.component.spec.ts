import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListShipsPageComponent } from './list-ships-page.component';

describe('ListShipsPageComponent', () => {
  let component: ListShipsPageComponent;
  let fixture: ComponentFixture<ListShipsPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListShipsPageComponent]
    });
    fixture = TestBed.createComponent(ListShipsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
