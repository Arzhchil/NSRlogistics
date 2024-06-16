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
    // Создать данные для диаграммы Ганта
    const data = [
      {
        id: '1',
        name: 'Project 1',
        actualStart: '2023-08-01',
        actualEnd: '2023-08-20',
        progressValue: '75%'
      },
      {
        id: '2',
        name: 'Project 2',
        actualStart: '2023-08-05',
        actualEnd: '2023-08-25',
        progressValue: '50%'
      }
    ];

    // Создаем диаграмму Ганта
    const chart = anychart.ganttProject();

    // Настраиваем данные
    chart.data(data);

    // Настраиваем контейнер для диаграммы
    chart.container('gantt-container');

    // Отрисовываем диаграмму
    chart.draw();
  }

}

