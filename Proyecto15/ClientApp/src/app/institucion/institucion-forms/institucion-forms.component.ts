import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { InstitucionService } from '../institucion.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Iinstitucion } from '../Institucion';
import { CategoriaService } from '../../categoria/categoria.service';
import { ICategoria } from '../../categoria/Categoria';
import { ISCategoria } from '../../sub-categoria/SubCategoria';
import { IGrupo } from '../../grupo/Grupo';
import { GrupoService } from '../../grupo/grupo.service';
import { SubCategoriaService } from '../../sub-categoria/sub-categoria.service';

@Component({
  selector: 'app-institucion-forms',
  templateUrl: './institucion-forms.component.html',
  styleUrls: ['./institucion-forms.component.css']
})
export class InstitucionFormsComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private InsititucionService: InstitucionService,
    private categoriaService: CategoriaService,
    private SubcategoriaService: SubCategoriaService,
    private grupoService: GrupoService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }


  formGroup: FormGroup;
  modoEdicion: boolean = false
  institucionId: number;


  grupo: IGrupo[];
  categoria: ICategoria[];
  subCategoria: ISCategoria[];




  ngOnInit() {

    this.categoriaService.getCategoria()
      .subscribe(categoriaDesdeWS => this.categoria = categoriaDesdeWS,
        error => console.error(error));
    this.SubcategoriaService.getSubCategoria()
      .subscribe(SubcategoriaDesdeWS => this.subCategoria = SubcategoriaDesdeWS,
        error => console.error(error));
    this.grupoService.getGrupo()
      .subscribe( grupoDesdeWS => this.grupo = grupoDesdeWS,
        error => console.error(error));

    this.formGroup = this.fb.group({
      
      razonSocial: '',
      alias: '',
      idGrupo: ''


    });

    this.activatedRoute.params.subscribe(params => {
      if (params["id"] == undefined) {
        return;
      }
      this.modoEdicion = true;
      this.institucionId = params["id"];

      this.InsititucionService.getinstituciones(this.institucionId.toString())
        .subscribe(institucion => this.cargarFormulario(institucion),
          error => this.router.navigate(["/institucion"]));
    });



  }

  cargarFormulario(institucion: Iinstitucion) {
    this.formGroup.patchValue({
      razonSocial: institucion.razonSocial,
      alias: institucion.alias,


    });
  }

  save() {
    let Institucion: Iinstitucion = Object.assign({}, this.formGroup.value);
    console.table(Institucion);


    if (this.modoEdicion) {
      //Editar Registro
      Institucion.idInstitucion = this.institucionId;
      this.InsititucionService.updateInstitucion(Institucion)
        .subscribe(Institucion => this.onSaveSuccess(),
          error => console.error(error));

    } else {
      //Agregar Registro


      this.InsititucionService.createInstitucion(Institucion)
        .subscribe(invitado => this.onSaveSuccess(),
          error => console.error(error));
    }



   
  }
  onSaveSuccess() {
    this.router.navigate(["/institucion"]);
  }
}
