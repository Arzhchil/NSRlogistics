import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';
import { SearchPathModel } from '../models';

@Injectable({
  providedIn: 'root',
})
export class PostSearchPathService {
  errorMessage: String = 'HttpError';
  private url = '/searchPath';
  constructor(private http: HttpClient) {}

  public PostSearchFile(searchFile: SearchPathModel): Observable<SearchPathModel> {
    return this.http.post<SearchPathModel>(environment.apiUrl + this.url, searchFile);
  }
}
