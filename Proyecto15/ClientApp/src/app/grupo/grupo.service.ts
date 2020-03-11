import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { IGrupo } from './Grupo';

@Injectable({
  providedIn: 'root'
})
export class GrupoService{

  private apiURL = this.baseUrl + "api/Grupo";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  getGrupo(): Observable<IGrupo[]> {

    return this.http.get<IGrupo[]>(this.apiURL);
  }
}
