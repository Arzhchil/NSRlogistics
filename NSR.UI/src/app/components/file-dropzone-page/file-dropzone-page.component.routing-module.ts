import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { FileDropzonePageComponent } from './file-dropzone-page.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: FileDropzonePageComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FileDropzonePageRoutingModule { }
