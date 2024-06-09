import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { FileDropzonePageComponent } from './components/file-dropzone-page/file-dropzone-page.component';
import { GanttChartPageComponent } from './components/gantt-chart-page/gantt-chart-page.component';
import { ListShipsPageComponent } from './components/list-ships-page/list-ships-page.component';
import { MainComponent } from './components/main/main.component';
import { TestingPageComponent } from './components/testing-page/testing-page.component';

const routes: Routes = [
  { path: '', redirectTo: 'main', pathMatch: 'full'},
  {path : 'upload', component : FileDropzonePageComponent},
  {path : 'gantt', component : GanttChartPageComponent},
  {path : 'main', component : MainComponent },
  {path : 'ships', component : ListShipsPageComponent},
  {path : 'test', component : TestingPageComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
