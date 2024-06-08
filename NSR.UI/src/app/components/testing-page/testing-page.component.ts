import { Component } from '@angular/core';

@Component({
  selector: 'app-testing-page',
  templateUrl: './testing-page.component.html',
  styleUrls: ['./testing-page.component.scss'],
})
export class TestingPageComponent {
  coordinates: { latitude: number; longitude: number }[] = [];

  constructor() {
    this.coordinates = [
      { latitude: 10, longitude: 20 },
      { latitude: 15, longitude: 25 },
      { latitude: 20, longitude: 30 },
      { latitude: 25, longitude: 35 },
      { latitude: 30, longitude: 40 },
      { latitude: 35, longitude: 45 },
      { latitude: 40, longitude: 50 },
      { latitude: 45, longitude: 55 },
      { latitude: 50, longitude: 60 },
      { latitude: 55, longitude: 65 },
      { latitude: 100, longitude: 100 },
      { latitude: 150, longitude: 100 },
      { latitude: 180, longitude: 180 },
    ];
  }
  // Функции для пересчета координат в размеры SVG
  normalizeLatitude(lat: number): number {
    return lat;
  }

  normalizeLongitude(lon: number): number {
    return lon;
  }
}
