import { Component, OnInit } from '@angular/core';
import {
  GuidGenerateService,
  PostRouteService,
  PostShipService,
  GetShipService,
} from 'src/app/shared/services';
import { Point, RouteModel, ShipModel } from 'src/app/shared/models';
import { v4 as uuidv4 } from 'uuid';
import { lastValueFrom } from 'rxjs';

@Component({
  selector: 'app-list-ships-page',
  templateUrl: './list-ships-page.component.html',
  styleUrls: ['./list-ships-page.component.scss'],
})
export class ListShipsPageComponent implements OnInit {
  uniqueId!: string;

  rawPointsData = `0  73.1  80  Бухта Север и Диксон  1010
  1  69.4  86.15  Дудинка  1007
  2  69.9  44.6  кромка льда на Западе  2002
  3  69.15  57.68  Варандей-Приразломное  1015
  4  73  44  Штокман  1012
  5  71.5  22  Окно в Европу  2001
  6  74.6  63.9  Победа месторождение  1011
  7  76.4  86.4  Карское - 3 (центр)  2008
  8  77.6  107.7  пролив Вилькицкого - 3  2013
  9  74.9  116.7  Лаптевых - 4 (юг)  2018
  10  73.1  72.7  Вход в Обскую губу  2009
  11  68.5  73.7  Новый порт  1004
  12  76.75  116  Лаптевых - 1 (центр)  2015
  13  74  76.7  Карское - 1 (сбор каравана)  2006
  14  72.35  79.6  Лескинское м-е  1014
  15  70.3  57.8  Карские ворота  2005
  16  77.3  67.7  Мыс Желания  2003
  17  71.74  184.7  остров Врангеля  2026
  18  70.7  170.5  Восточно-Сибирское - 1 (восток)  2023
  19  77.8  104.1  пролив Вилькицкого - восток  2012
  20  77.7  99.5  пролив Вилькицкого - запад  2011
  21  76.2  58.3  около Новой Земли  2004
  22  74.4  139  Пролив Санникова - 1  2020
  23  74.3  146.7  Пролив Санникова - 2  2021
  24  74  128.1  устье Лены  2019
  25  71.3  72.15  Сабетта  1003
  26  69.1  169.4  мыс.Наглёйнын  1009
  27  69.9  179  пролив Лонга  2027
  28  73.5  169.9  Восточно-Сибирское - 3 (север)  2025
  29  64.95  40.05  Архангельск  1002
  30  75.9  152.6  Лаптевых - 3 (восток)  2017
  31  68.37  54.6  МОТ Печора  1017
  32  73.7  109.26  Хатангский залив  1008
  33  72  159.5  Восточно-Сибирское - 2 (запад)  2024
  34  72.4  65.6  Ленинградское-Русановское  1013
  35  71  73.73  терминал Утренний  1005
  36  76.5  97.6  Таймырский залив  2010
  37  64.2  188.2  Берингово  2029
  38  60.7  175.3  кромка льда на Востоке  2030
  39  69.75  169.9  Рейд Певек  1006
  40  75.5  131.5  Лаптевых - 2 (центр)  2016
  41  69.5  33.75  Рейд Мурманска  1001
  42  76.7  140.8  остров Котельный  2022
  43  74.8  84.2  Карское - 2 (прибрежный)  2007
  44  67.58  47.82  Индига  1016
  45  65.9  -169.35  Берингов пролив  2028
  46  55.7  164.25  Окно в Азию  2031`;

  PointData: Point[] = [];
  start: string = '';
  finish: string = '';
  routes: RouteModel = new RouteModel();

  ship: string = '';
  parsedShipsData: ShipModel[] = [];
  selectedShip: ShipModel = new ShipModel();

  constructor(
    private guidService: GuidGenerateService,
    private routeService: PostRouteService,
    private shipService: PostShipService,
    private getShipService: GetShipService
  ) {
    this.uniqueId = this.guidService.generateGuid();
    this.PointData = this.rawPointsData
      .split('\n')
      .map(this.parsePointData);
  }

  ngOnInit(): void {
    this.getShipService.getShips().subscribe({
      next: (ships: ShipModel[]) => {
        this.parsedShipsData = ships;
        console.log(this.parsedShipsData) //убрать
      },
      error: (error) => {
        console.error(error);
      },
    });
  }

  parsePointData = (line: string): Point => {
    const parts = line.trim().split(/\s+/);
    const pointName = parts.slice(3, -1).join(' ');
    const repId = parseInt(parts[parts.length - 1], 10);
    return {
      id: uuidv4(),
      latitude: parseFloat(parts[1].replace(',', '.')),
      longitude: parseFloat(parts[2].replace(',', '.')),
      pointName: pointName,
      repId: repId,
    };
  };

  public async postRoute(routes: RouteModel) {
    let t = this;

    await lastValueFrom(t.routeService.PostRoute(routes))
      .then((res) => {
        console.log(res); //убрать
      })
      .catch((e) => {
        console.error('Ошибка при загрузке маршрута', e);
      });
  }

  public async postShip(ship: ShipModel) {
    let t = this;

    await lastValueFrom(t.shipService.PostShip(ship))
      .then((res) => {
        console.log(res); //убрать
      })
      .catch((e) => {
        console.error('Ошибка при загрузке маршрута', e);
      });
  }

  sendRoute = (): void => {
    let t = this;
    const selectedStartPoint = t.PointData.find(
      (point) => point.id === t.start
    );
    const selectedEndPoint = t.PointData.find(
      (point) => point.id === t.finish
    );
    const selectedShip = t.parsedShipsData.find(
      (ship) => ship.shipName === t.ship
    );

    if (selectedStartPoint && selectedEndPoint && selectedShip) {
      const route = {
        id: uuidv4(),
        start: selectedStartPoint,
        startId: selectedStartPoint.id,
        finish: selectedEndPoint,
        finishId: selectedEndPoint.id,
      };
      const currentShip = {
        shipName: selectedShip.shipName,
        speed: selectedShip.speed,
        shipClassId: selectedShip.shipClassId,
      };

      t.routes = route;
      t.selectedShip = currentShip;
      t.start = '';
      t.finish = '';

      console.log('routes:', t.routes); //убрать
      console.log('currentShip:', t.selectedShip); //убрать
      //t.postRoute(t.routes);
      //t.postShip(t.selectedShip);
    }
  };
}
