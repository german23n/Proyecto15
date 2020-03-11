import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Iinstitucion } from './Institucion';

@Injectable({
  providedIn: 'root'
})
export class InstitucionService {
  private apiURL = this.baseUrl + "api/Institucion";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }



  getInstitucion(): Observable<Iinstitucion[]> {

 
    return this.http.get<Iinstitucion[]>(this.apiURL);
  }
}
