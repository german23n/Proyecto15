import { Component, OnInit } from '@angular/core';
import { ISCategoria } from './SubCategoria';
import { SubCategoriaService } from './sub-categoria.service';

@Component({
  selector: 'app-sub-categoria',
  templateUrl: './sub-categoria.component.html',
  styleUrls: ['./sub-categoria.component.css']
})
export class SubCategoriaComponent implements OnInit {

  constructor(private SubCategoriaService: SubCategoriaService) {}

  subcategoria: ISCategoria[];

  ngOnInit() {

    this.SubCategoriaService.getSubCategoria()
      .subscribe(SubcategoriaDesdeWS => this.subcategoria = SubcategoriaDesdeWS,
        error => console.error(error));


  }

}
