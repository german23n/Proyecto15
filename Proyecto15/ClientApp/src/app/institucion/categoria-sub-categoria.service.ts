import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { ICSC } from './Institucion';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoriaSubCategoriaService {

  private apiURL = this.baseUrl + "api/CategoriaSubCategorias";

   constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getCSC(): Observable<ICSC[]> {

    return this.http.get<ICSC[]>(this.apiURL);

  }
}
