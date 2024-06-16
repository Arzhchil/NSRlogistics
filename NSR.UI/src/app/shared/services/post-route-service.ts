import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { RouteModel } from '../models';

@Injectable({
  providedIn: 'root',
})
export class PostRouteService {
  errorMessage: String = 'HttpError';
  private url = '/api/Route';
  constructor(private http: HttpClient) {}

  public PostRoute(route: RouteModel): Observable<RouteModel> {
    return this.http.post<RouteModel>(environment.apiUrl + this.url, route);
  }

  public getRoute(): Observable<RouteModel[]> {
    return this.http.get<RouteModel[]>(environment.apiUrl + this.url);
  }
}
