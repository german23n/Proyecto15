import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ICategoria } from './Categoria';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private apiURL = this.baseUrl + "api/Categoria";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  getCategoria(): Observable<ICategoria[]> {
    return this.http.get<ICategoria[]>(this.apiURL);
  }
}
