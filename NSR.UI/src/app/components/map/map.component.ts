import { Component, OnInit } from '@angular/core';
import * as L from 'leaflet';
import { GetMapPointService, PostRouteService } from 'src/app/shared/services';
import { Point, PointMap, RouteModel } from 'src/app/shared/models';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss'],
})
export class MapComponent implements OnInit {
  constructor(
    private getPointMapService: GetMapPointService,
    private routeService: PostRouteService
  ) {}

  options = {
    layers: [
      L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
      }),
    ],
    zoom: 4,
    center: L.latLng(60.4, 100.15),
  };

  PointData: PointMap[] = [];
  routeData: RouteModel[] = [];

  ngOnInit(): void {
    const map = L.map('map', this.options);
    this.addCirclesAndRoutesToMap(map);

    this.getPointMapService.getMapPoint().subscribe({
      next: (points: PointMap[]) => {
        this.PointData = points;
        console.log(points);
        this.routeService.getRoute().subscribe({
          next: (routes: RouteModel[]) => {
            console.log(routes);
            this.routeData = routes;
            this.addCirclesAndRoutesToMap(map);
          },
          error: (error) => {
            console.error(error);
          },
        });
      },
      error: (error) => {
        console.error(error);
      },
    });
  }

  addCirclesAndRoutesToMap(map: L.Map) {
    this.routeData.forEach((route) => {
      const startPoint = this.PointData.find(
        (point) => point.graphDataId === route.startId
      );
      const finishPoint = this.PointData.find(
        (point) => point.graphDataId === route.finishId
      );
      if (
        route.startId === '477268b0-ee0b-4105-a95a-02d927fd70b4' ||
        route.finishId === '477268b0-ee0b-4105-a95a-02d927fd70b4'
      ) {
        return;
      }

      if (startPoint) {
        L.circle([startPoint.latitude, startPoint.longitude], {
          radius: 50,
          color: 'red',
          fillColor: '#f03',
          fillOpacity: 0.5,
        })
          .addTo(map)
          .bindPopup(`Start Point: ${startPoint.graphDataId}`);
      }

      if (finishPoint) {
        L.circle([finishPoint.latitude, finishPoint.longitude], {
          radius: 50,
          color: 'blue',
          fillColor: '#30f',
          fillOpacity: 0.5,
        })
          .addTo(map)
          .bindPopup(`Finish Point: ${finishPoint.graphDataId}`);
        const latlngs: L.LatLngTuple[] = [
          [startPoint!.latitude, startPoint!.longitude],
          [finishPoint.latitude, finishPoint.longitude],
        ];
        const polyline = L.polyline(latlngs, { color: 'green' }).addTo(map);
        map.fitBounds(polyline.getBounds());
      }
    });
  }
}
