import { Component, OnInit } from '@angular/core';
import * as anychart from 'anychart';

@Component({
  selector: 'app-gantt-chart',
  templateUrl: './gantt-chart.component.html',
  styleUrls: ['./gantt-chart.component.scss']
})
export class GanttChartComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    const data = [
      {
        id: '1',
        name: 'Hackaton',
        actualStart: '2024-06-03',
        actualEnd: '2024-06-16',
        test: 'ЛЕДокол',
        progressValue: '75%'
      },
      //{
      //  id: '2',
      //  name: 'Project 2',
      //  actualStart: '2023-08-05',
      //  actualEnd: '2023-08-25',
      //  progressValue: '50%'
      //}
    ];

    const chart = anychart.ganttProject();

    chart.data(data);

    chart.container('gantt-container');

    chart.draw();
  }

}

