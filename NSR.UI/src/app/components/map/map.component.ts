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

  ngOnInit(): void {
    this.initMap();
    this.getMapPoints();
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
        this.mapCoord.forEach((coordinate) => {
          const circleMarker = L.circleMarker(
            [coordinate.latitude, coordinate.longitude],
            {
              radius: 5,
              color: 'red',
              fillColor: 'red',
              fillOpacity: 1,
            }
          );
          circleMarker.bindPopup(
            `Точка [${coordinate.longitude}, ${coordinate.latitude}, ${coordinate.pointName}]`
          );
          circleMarker.addTo(this.map);
        });
      },
      error: (error) => {
        console.error(error);
      },
    });
  }
}
