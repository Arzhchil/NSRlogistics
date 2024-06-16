import { Component, OnInit } from '@angular/core';
import * as L from 'leaflet';
import { GetMapPointService } from 'src/app/shared/services';
import { PointMap } from 'src/app/shared/models';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss'],
})
export class MapComponent implements OnInit {
  constructor(private getPointMapService: GetMapPointService) {}

  private mapCoord: PointMap[] = [];
  private map!: L.Map;
  private coords: [number, number, string][][] = [
    [
      //[73.1, 80, 'Бухта Север и Диксон'],
      [69.4, 86.15, 'Дудинка'],
      //[69.9, 44.6, 'кромка льда на Западе'],
      //[69.15, 57.68, 'Варандей-Приразломное'],
      [73, 44, 'Штокман'],
      //[71.5, 22, 'Окно в Европу'],
      //[74.6, 63.9, 'Победа месторождение'],
      //[76.4, 86.4, 'Карское - 3 (центр)'],
      //[77.6, 107.7, 'пролив Вилькицкого - 3'],
      //[74.9, 116.7, 'Лаптевых - 4 (юг)'],
      //[73.1, 72.7, 'Вход в Обскую губу'],
      //[68.5, 73.7, 'Новый порт'],
      //[76.75, 116, 'Лаптевых - 1 (центр)'],
      //[74, 76.7, 'Карское - 1 (сбор каравана)'],
      //[72.35, 79.6, 'Лескинское м-е'],
      //[70.3, 57.8, 'Карские ворота'],
      //[77.3, 67.7, 'Мыс Желания'],
      //[71.74, 184.7, 'остров Врангеля'],
      //[70.7, 170.5, 'Восточно-Сибирское - 1 (восток)'],
      //[77.8, 104.1, 'пролив Вилькицкого - восток'],
      //[77.7, 99.5, 'пролив Вилькицкого - запад'],
      //[76.2, 58.3, 'около Новой Земли'],
      //[74.4, 139, 'Пролив Санникова - 1'],
      //[74.3, 146.7, 'Пролив Санникова - 2'],
      //[74, 128.1, 'устье Лены'],
      [71.3, 72.15, 'Сабетта'],
      //[69.1, 169.4, 'мыс.Наглёйнын'],
      [69.9, 179, 'пролив Лонга'],
      //[73.5, 169.9, 'Восточно-Сибирское - 3 (север)'],
      //[64.95, 40.05, 'Архангельск'],
      //[75.9, 152.6, 'Лаптевых - 3 (восток)'],
      //[68.37, 54.6, 'МОТ Печора'],
      //[73.7, 109.26, 'Хатангский залив'],
      //[72, 159.5, 'Восточно-Сибирское - 2 (запад)'],
      //[72.4, 65.6, 'Ленинградское-Русановское'],
      [71, 73.73, 'терминал Утренний'],
      //[76.5, 97.6, 'Таймырский залив'],
      //[64.2, 188.2, 'Берингово'],
      //[60.7, 175.3, 'кромка льда на Востоке'],
      //[69.75, 169.9, 'Рейд Певек'],
      //[75.5, 131.5, 'Лаптевых - 2 (центр)'],
      //[69.5, 33.75, 'Рейд Мурманска'],
      //[76.7, 140.8, 'остров Котельный'],
      //[74.8, 84.2, 'Карское - 2 (прибрежный)'],
      //[67.58, 47.82, 'Индига'],
      //[65.9, -169.35, 'Берингов пролив'],
      //[55.7, 164.25, 'Окно в Азию'],
    ],
  ];

  ngOnInit(): void {
    this.initMap();
    this.getMapPoints();
    // Add markers
    this.coords.forEach((points) => {
      points.forEach(([latitude, longitude, namePoint], index) => {
        const circleMarker = L.circleMarker([latitude, longitude], {
          radius: 5,
          color: 'red',
          fillColor: 'red',
          fillOpacity: 1,
        });

        // Popup
        circleMarker.bindPopup(
          `Порт ${index + 1}: [${latitude}, ${longitude}, ${namePoint}]`
        );

        circleMarker.addTo(this.map);
      });
    });

    this.mapCoord.forEach((coordinate) => {
      const circleMarker = L.circleMarker([coordinate.x, coordinate.y], {
        radius: 5,
        color: 'red',
        fillColor: 'red',
        fillOpacity: 1,
      });
      circleMarker.bindPopup(`Точка [${coordinate.x}, ${coordinate.y}]`);
      circleMarker.addTo(this.map);
    });
  }

  private initMap(): void {
    this.map = L.map('map', {
      center: [60.4, 100.15],
      zoom: 4,
    });

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      maxZoom: 19,
    }).addTo(this.map);
  }

  getMapPoints() {
    this.getPointMapService.getMapPoint().subscribe({
      next: (points: PointMap[]) => {
        this.mapCoord = points;
        console.log(this.mapCoord); //убрать
      },
      error: (error) => {
        console.error(error);
      },
    });
  }
}
