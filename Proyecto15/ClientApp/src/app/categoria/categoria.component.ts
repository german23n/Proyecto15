import { Component, OnInit } from '@angular/core';
import { CategoriaService } from './categoria.service';
import { ICategoria } from './Categoria';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit {

  constructor(private CategoriaService: CategoriaService) { }

  categoria: ICategoria[];

  ngOnInit() {
    this.CategoriaService.getCategoria()
      .subscribe(categoriaDesdeWS => this.categoria = categoriaDesdeWS,
        error => console.error(error));


  }

}
