import { Component, OnInit } from '@angular/core';
import { InstitucionService } from './institucion.service';
import { Iinstitucion, ICSC } from './Institucion';

@Component({
  selector: 'app-institucion',
  templateUrl: './institucion.component.html',
  styleUrls: ['./institucion.component.css']
})
export class InstitucionComponent implements OnInit {

  constructor(private InstitucionService: InstitucionService,
    private CategoriaSubCategoriaService: CategoriaSubCategoriaService) { }
 

  institucion: Iinstitucion[];
  categoriSubCategoria: ICSC[];

  ngOnInit() {
    this.InstitucionService.getInstitucion()
      .subscribe(institucionDesdeWS => this.institucion = institucionDesdeWS,
        error => console.error(error));

    this.CategoriaSubCategoriaService.getInstitucion()
      .subscribe(institucionDesdeWS => this.institucion = institucionDesdeWS,
        error => console.error(error));


  }

}
