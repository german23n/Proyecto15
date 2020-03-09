import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { ISCategoria } from './SubCategoria';

@Injectable({
  providedIn: 'root'
})
export class SubCategoriaService {
  private apiURL = this.baseUrl + "api/SubCategoria";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  getSubCategoria(): Observable<ISCategoria[]> {
    return this.http.get<ISCategoria[]>(this.apiURL);
  }
}
