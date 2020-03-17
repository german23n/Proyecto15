import { Component, OnInit } from '@angular/core';
import { InstitucionService } from './institucion.service';
import { Iinstitucion, ICSC } from './Institucion';
import { CategoriaSubCategoriaService } from './categoria-sub-categoria.service';

@Component({
  selector: 'app-institucion',
  templateUrl: './institucion.component.html',
  styleUrls: ['./institucion.component.css']
})
export class InstitucionComponent implements OnInit {

  //constructor(private CategoriaSubCategoria: CategoriaSubCategoriaService) { }
  constructor(private InstitucionService: InstitucionService,
          private CategoriaSubCategoriaService: CategoriaSubCategoriaService) { }
 
   
  institucion: Iinstitucion[];
  categoriSubCategoria: ICSC[];

  ngOnInit() {

    this.InstitucionService.getInstitucion()
      .subscribe(institucion => this.institucion = institucion,
        error => console.error(error));

    this.CategoriaSubCategoriaService.getCSC()
      .subscribe(categoriSubCategoria => this.categoriSubCategoria = categoriSubCategoria,
        error => console.error(error));


  }

}
