import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListShipsPageComponent } from './list-ships-page.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: ListShipsPageComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ListShipsPageRoutingModule { }
