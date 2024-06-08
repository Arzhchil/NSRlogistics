import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments';

@Injectable({
  providedIn: 'root',
})
export class FileUploadService {
  errorMessage: String = 'HttpError';
  private url = '/upload'; //Поправить
  constructor(private http: HttpClient) {}
  uploadFiles(file: File): Observable<any> {
    const formData = new FormData();
    formData.append('file', file, file.name);
    return this.http.post(environment.apiUrl + this.url, formData);
  }
}
