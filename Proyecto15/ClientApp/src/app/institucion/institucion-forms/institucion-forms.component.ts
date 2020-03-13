import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { InstitucionService } from '../institucion.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Iinstitucion } from '../Institucion';

@Component({
  selector: 'app-institucion-forms',
  templateUrl: './institucion-forms.component.html',
  styleUrls: ['./institucion-forms.component.css']
})
export class InstitucionFormsComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private InsititucionService: InstitucionService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }

  formGroup: FormGroup;
  modoEdicion: boolean = false
  institucionId: number;


  ngOnInit() {
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
