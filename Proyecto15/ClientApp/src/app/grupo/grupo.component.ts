import { Component, OnInit } from '@angular/core';
import { IGrupo } from './Grupo';
import { GrupoService } from './grupo.service';

@Component({
  selector: 'app-grupo',
  templateUrl: './grupo.component.html',
  styleUrls: ['./grupo.component.css']
})
export class GrupoComponent implements OnInit {


  constructor(private GrupoService: GrupoService) { }

  grupo: IGrupo[];

  ngOnInit() {

    this.GrupoService.getGrupo()
      .subscribe(grupoDesdeWS => this.grupo = grupoDesdeWS,
        error => console.error(error));

  }

}
