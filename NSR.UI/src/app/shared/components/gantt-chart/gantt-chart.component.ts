import { Component, OnInit } from '@angular/core';
import * as anychart from 'anychart';

@Component({
  selector: 'app-gantt-chart',
  templateUrl: './gantt-chart.component.html',
  styleUrls: ['./gantt-chart.component.scss'],
})
export class GanttChartComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {
    const data = [
      {
        id: '1',
        name: 'GEORGIY USHAKOV - VLADIMIR VORONIN - CHRISTOPHE DE MARGERIE',
        actualStart: '2022-03-04',
        actualEnd: '2022-03-20',
        progressValue: '0%',
        children: [
          {
            id: '1_1',
            name: 'GEORGIY USHAKOV: Штокман - Пролив Лонга',
            actualStart: '2022-03-04',
            actualEnd: '2022-03-20',
            progressValue: '0%',
          },
          {
            id: '1_2',
            name: 'VLADIMIR VORONIN: Сабетта -  Пролив Лонга',
            actualStart: '2022-03-7',
            actualEnd: '2022-03-20',
            progressValue: '0%',
          },
          {
            id: '1_3',
            name: 'CHRISTOPHE DE MARGERIE: Окно в Европу - Терминал Утренний',
            actualStart: '2022-03-8',
            actualEnd: '2022-03-15',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '2',
        name: 'RUDOLF SAMOYLOVICH - BORIS VILKITSKY - ИНЖЕНЕР ВЕШНЯКОВ',
        actualStart: '2022-03-07',
        actualEnd: '2022-03-18',
        progressValue: '0%',
        children: [
          {
            id: '2_1',
            name: 'RUDOLF SAMOYLOVICH: Новый порт - устье Лены',
            actualStart: '2022-03-07',
            actualEnd: '2022-03-18',
            progressValue: '0%',
          },
          {
            id: '2_2',
            name: 'BORIS VILKITSKY: Окно в Европу - Терминал Утренний',
            actualStart: '2022-03-08',
            actualEnd: '2022-03-18',
            progressValue: '0%',
          },
          {
            id: '2_3',
            name: 'ИНЖЕНЕР ВЕШНЯКОВ: Окно в Европу - Терминал Утренний',
            actualStart: '2022-03-10',
            actualEnd: '2022-03-18',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '3',
        name: 'ТАМБЕЙ - НИКИФОР БЕГИЧЕВ - ШТУРМАН ЩЕРБИНИН',
        actualStart: '2022-03-12',
        actualEnd: '2022-03-26',
        progressValue: '0%',
        children: [
          {
            id: '3_1',
            name: 'ТАМБЕЙ: Окно в Европу - Терминал Утренний',
            actualStart: '2022-03-12',
            actualEnd: '2022-03-18',
            progressValue: '0%',
          },
          {
            id: '3_2',
            name: 'НИКИФОР БЕГИЧЕВ: Новый порт - Окно в Европу',
            actualStart: '2022-03-13',
            actualEnd: '2022-03-21',
            progressValue: '0%',
          },
          {
            id: '3_3',
            name: 'ШТУРМАН ЩЕРБИНИН: Победа месторождение - Окно в Европу',
            actualStart: '2022-03-17',
            actualEnd: '2022-03-26',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '4',
        name: 'ДЮК II - АРКТИКА-2 - ШТУРМАН СКУРАТОВ',
        actualStart: '2022-03-01',
        actualEnd: '2022-03-28',
        progressValue: '0%',
        children: [
          {
            id: '4_1',
            name: 'ДЮК II: Новый порт - Рейд Мурманска',
            actualStart: '2022-03-01',
            actualEnd: '2022-03-09',
            progressValue: '0%',
          },
          {
            id: '4_2',
            name: 'АРКТИКА-2: Терминал Утренний - устье Лены',
            actualStart: '2022-03-09',
            actualEnd: '2022-03-28',
            progressValue: '0%',
          },
          {
            id: '4_3',
            name: 'ШТУРМАН СКУРАТОВ: Терминал Утренний - устье Лены',
            actualStart: '2022-03-19',
            actualEnd: '2022-03-28',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '5',
        name: 'EDUARD TOLL - ИОГАНН МАХМАСТАЛЬ - BORIS SOKOLOV',
        actualStart: '2022-03-04',
        actualEnd: '2022-03-31',
        progressValue: '0%',
        children: [
          {
            id: '5_1',
            name: 'EDUARD TOLL: Сабетта - Рейд Мурманска',
            actualStart: '2022-03-04',
            actualEnd: '2022-03-13',
            progressValue: '0%',
          },
          {
            id: '5_2',
            name: 'ИОГАНН МАХМАСТАЛЬ: Новый порт - Окно в Европу',
            actualStart: '2022-03-19',
            actualEnd: '2022-03-28',
            progressValue: '0%',
          },
          {
            id: '5_3',
            name: 'BORIS SOKOLOV: Архангельск - Дудинка',
            actualStart: '2022-03-20',
            actualEnd: '2022-03-31',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '6',
        name: 'МЫС ДЕЖНЕВА - ПРОГРЕСС - YAMAL SPIRIT',
        actualStart: '2022-04-01',
        actualEnd: '2022-05-08',
        progressValue: '0%',
        children: [
          {
            id: '6_1',
            name: 'МЫС ДЕЖНЕВА: Победа месторождение - Дудинка',
            actualStart: '2022-04-01',
            actualEnd: '2022-04-09',
            progressValue: '0%',
          },
          {
            id: '6_2',
            name: 'ПРОГРЕСС: Штокман - Терминал УТренний',
            actualStart: '2022-04-15',
            actualEnd: '2022-04-23',
            progressValue: '0%',
          },
          {
            id: '6_3',
            name: 'YAMAL SPIRIT: Сабетта - Архангельск',
            actualStart: '2022-04-27',
            actualEnd: '2022-05-08',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '7',
        name: 'ФЕСКО ПАРИС - СЕВЕРНЫЙ ПРОЕКТ - НИКОЛАЙ ЧУДОТВОРЕЦ',
        actualStart: '2022-04-01',
        actualEnd: '2022-05-01',
        progressValue: '0%',
        children: [
          {
            id: '7_1',
            name: 'ФЕСКО ПАРИС: Терминал Утренний - Пролив Лонга',
            actualStart: '2022-04-01',
            actualEnd: '2022-04-09',
            progressValue: '0%',
          },
          {
            id: '7_2',
            name: 'СЕВЕРНЫЙ ПРОЕКТ: Сабетта - Окно в Европу',
            actualStart: '2022-04-20',
            actualEnd: '2022-04-28',
            progressValue: '0%',
          },
          {
            id: '7_3',
            name: 'НИКОЛАЙ ЧУДОТВОРЕЦ: Сабетта - Окно в Европу',
            actualStart: '2022-04-22',
            actualEnd: '2022-05-01',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '8',
        name: 'НОРИЛЬСКИЙ НИКЕЛЬ - ТОЛБУХИН - NIKOLAY YEVGENOV',
        actualStart: '2022-03-07',
        actualEnd: '2022-04-30',
        progressValue: '0%',
        children: [
          {
            id: '8_1',
            name: 'НОРИЛЬСКИЙ НИКЕЛЬ: Мыс Желания - устье Лены',
            actualStart: '2022-03-15',
            actualEnd: '2022-03-24',
            progressValue: '0%',
          },
          {
            id: '8_2',
            name: 'ТОЛБУХИН: Рейд Мурманска - Дудинка',
            actualStart: '2022-04-23',
            actualEnd: '2022-04-30',
            progressValue: '0%',
          },
          {
            id: '8_3',
            name: 'NIKOLAY YEVGENOV: Терминал Утренний - Пролив Лонга',
            actualStart: '2022-03-07',
            actualEnd: '2022-03-20',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '9',
        name: 'САРМАТ - ШТУРМАН КОШЕЛЕВ - ГРИГОРИЙ ШЕЛИХОВ',
        actualStart: '2022-03-02',
        actualEnd: '2022-04-16',
        progressValue: '0%',
        children: [
          {
            id: '9_1',
            name: 'САРМАТ: Сабетта - Архангельск',
            actualStart: '2022-03-02',
            actualEnd: '2022-03-10',
            progressValue: '0%',
          },
          {
            id: '9_2',
            name: 'ШТУРМАН КОШЕЛЕВ: Пролив Лонга - Сабетта',
            actualStart: '2022-03-16',
            actualEnd: '2022-03-28',
            progressValue: '0%',
          },
          {
            id: '9_3',
            name: 'ГРИГОРИЙ ШЕЛИХОВ: Новый порт - устье Лены',
            actualStart: '2022-04-07',
            actualEnd: '2022-04-16',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '10',
        name: 'БАРЕНЦ - ПОЛАР КИНГ - САБЕТТА',
        actualStart: '2022-03-24',
        actualEnd: '2022-04-27',
        progressValue: '0%',
        children: [
          {
            id: '10_1',
            name: 'БАРЕНЦ: Восточно-Сибирское 1 - Рейд Мурманска',
            actualStart: '2022-03-24',
            actualEnd: '2022-04-03',
            progressValue: '0%',
          },
          {
            id: '10_2',
            name: 'ПОЛАР КИНГ: Восточно-Сибирское 3 - Архангельск',
            actualStart: '2022-03-26',
            actualEnd: '2022-04-04',
            progressValue: '0%',
          },
          {
            id: '10_3',
            name: 'САБЕТТА: Индига - Победа Месторождение',
            actualStart: '2022-04-16',
            actualEnd: '2022-04-27',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '11',
        name: 'УРАРТУ - МИХАИЛ БРИТНЕВ - CLEAN VISION',
        actualStart: '2022-04-08',
        actualEnd: '2022-05-03',
        progressValue: '0%',
        children: [
          {
            id: '11_1',
            name: 'УРАРТУ: Архангельск - устье Лены',
            actualStart: '2022-04-08',
            actualEnd: '2022-04-19',
            progressValue: '0%',
          },
          {
            id: '11_2',
            name: 'МИХАИЛ БРИТНЕВ: Рейд Мурманска - Новый порт',
            actualStart: '2022-04-16',
            actualEnd: '2022-04-25',
            progressValue: '0%',
          },
          {
            id: '11_3',
            name: 'CLEAN VISION: Штокман - устье Лены',
            actualStart: '2022-04-25',
            actualEnd: '2022-05-03',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '12',
        name: 'БЕРИНГ - ЯМАЛ КРЕЧЕТ - ТАЙБОЛА',
        actualStart: '2022-04-23',
        actualEnd: '2022-05-04',
        progressValue: '0%',
        children: [
          {
            id: '12_1',
            name: 'БЕРИНГ: Окно в Европу - Терминал Утренний',
            actualStart: '2022-04-23',
            actualEnd: '2022-05-04',
            progressValue: '0%',
          },
          {
            id: '12_2',
            name: 'ЯМАЛ КРЕЧЕТ: Штокман - Новый порт',
            actualStart: '2022-04-25',
            actualEnd: '2022-05-01',
            progressValue: '0%',
          },
          {
            id: '12_3',
            name: 'ТАЙБОЛА: Рейд Мурманска - Новый порт',
            actualStart: '2022-04-30',
            actualEnd: '2022-05-04',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '13',
        name: 'ТИКСИ - ГЕОРГИЙ УШАКОВ',
        actualStart: '2022-04-16',
        actualEnd: '2022-05-04',
        progressValue: '0%',
        children: [
          {
            id: '13_1',
            name: 'ТИКСИ: Новый порт - Окно в Европу',
            actualStart: '2022-04-27',
            actualEnd: '2022-05-04',
            progressValue: '0%',
          },
          {
            id: '13_2',
            name: 'ГЕОРГИЙ УШАКОВ: Пролив Лонга - Штокман',
            actualStart: '2022-04-16',
            actualEnd: '2022-04-30',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '14',
        name: 'ШТУРМАН АЛЬБАНОВ - СЕВМОРПУТЬ',
        actualStart: '2022-03-13',
        actualEnd: '2022-05-04',
        progressValue: '0%',
        children: [
          {
            id: '14_1',
            name: 'ШТУРМАН АЛЬБАНОВ: Штокман - Дудинка',
            actualStart: '2022-03-13',
            actualEnd: '2022-03-21',
            progressValue: '0%',
          },
          {
            id: '14_2',
            name: 'СЕВМОРПУТЬ: Штокман - Дудинка',
            actualStart: '2022-04-06',
            actualEnd: '2022-04-14',
            progressValue: '0%',
          },
        ],
      },
      {
        id: '15',
        name: 'АЙС ИГЛ - ИНЖЕНЕР ТРУБИН',
        actualStart: '2022-03-16',
        actualEnd: '2022-04-05',
        progressValue: '0%',
        children: [
          {
            id: '15_1',
            name: 'АЙС ИГЛ: Новый порт - Штокман',
            actualStart: '2022-03-16',
            actualEnd: '2022-03-25',
            progressValue: '0%',
          },
          {
            id: '15_2',
            name: 'ИНЖЕНЕР ТРУБИН: устье Лены - Новый порт',
            actualStart: '2022-03-24',
            actualEnd: '2022-04-05',
            progressValue: '0%',
          },
        ],
      },
    ];

    const chart = anychart.ganttProject();

    chart.data(data);

    chart.container('gantt-container');

    chart.draw();
  }
}
