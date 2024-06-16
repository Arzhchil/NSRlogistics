import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { PointMap } from '../models';

@Injectable({
  providedIn: 'root',
})
export class GetMapPointService {
  errorMessage: String = 'HttpError';
  private url = '/api/GraphData';
  constructor(private http: HttpClient) {}

  getMapPoint(): Observable<PointMap[]> {
    return this.http.get<PointMap[]>(environment.apiUrl + this.url);
  }
}
