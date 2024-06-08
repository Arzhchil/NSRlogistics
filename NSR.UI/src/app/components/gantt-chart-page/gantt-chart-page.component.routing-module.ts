import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GanttChartPageComponent } from './gantt-chart-page.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: GanttChartPageComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GanttChartPageRoutingModule { }
