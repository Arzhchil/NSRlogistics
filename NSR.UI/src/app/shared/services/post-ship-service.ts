import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { ShipModel } from '../models';

@Injectable({
  providedIn: 'root',
})
export class PostShipService {
  errorMessage: String = 'HttpError';
  private url = '/api/Ship';
  constructor(private http: HttpClient) {}

  public PostShip(ship: ShipModel): Observable<ShipModel> {
    return this.http.post<ShipModel>(environment.apiUrl + this.url, ship);
  }
}
