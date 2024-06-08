import { Routes } from '@angular/router';

export const content: Routes = [
  {
    path: 'upload',
    loadChildren: () =>
      import(
        '../../components/file-dropzone-page/file-dropzone-page.component.module'
      ).then((m) => m.FileDropzonePageModule),
    data: {
      breadcrumb: '',
    },
  },
  {
    path: 'gantt',
    loadChildren: () =>
      import(
        '../../components/gantt-chart-page/gantt-chart-page.component.module'
      ).then((m) => m.GanttChartPageModule),
    data: {
      breadcrumb: '',
    },
  },
  {
    path: 'ships',
    loadChildren: () =>
      import(
        '../../components/list-ships-page/list-ships-page.component.module'
      ).then((m) => m.ListShipsPageModule),
    data: {
      breadcrumb: '',
    },
  },
];
