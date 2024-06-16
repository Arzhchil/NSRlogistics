import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { Point } from '../models';

@Injectable({
  providedIn: 'root',
})
export class GetPointService {
  errorMessage: String = 'HttpError';
  private url = '/api/GraphData';
  constructor(private http: HttpClient) {}

  getPoints(): Observable<Point[]> {
    return this.http.get<Point[]>(environment.apiUrl + this.url);
  }
}
