import { Component, OnInit } from '@angular/core';
import { InstitucionService } from './institucion.service';
import { Iinstitucion } from './Institucion';

@Component({
  selector: 'app-institucion',
  templateUrl: './institucion.component.html',
  styleUrls: ['./institucion.component.css']
})
export class InstitucionComponent implements OnInit {

  constructor(private InstitucionService: InstitucionService) { }

  institucion: Iinstitucion[];

  ngOnInit() {
    this.InstitucionService.getInstitucion()
      .subscribe(institucionDesdeWS => this.institucion = institucionDesdeWS,
        error => console.error(error));


  }

}
