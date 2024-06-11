import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { ShipModel } from '../models';

@Injectable({
  providedIn: 'root'
})
export class GetShipService {
  errorMessage: String = 'HttpError';
  private url = '/api/Ship';
  constructor(private http: HttpClient) { }

  // Метод для получения списка кораблей
  getShips(): Observable<ShipModel[]> {
    return this.http.get<ShipModel[]>(environment.apiUrl + this.url);
  }
}
