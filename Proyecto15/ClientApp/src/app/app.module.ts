import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CategoriaComponent } from './categoria/categoria.component';
import { CategoriaService } from './categoria/categoria.service';
import { SubCategoriaComponent } from './sub-categoria/sub-categoria.component';
import { SubCategoriaService } from './sub-categoria/sub-categoria.service';
import { InstitucionComponent } from './institucion/institucion.component';
import { InstitucionService } from './institucion/institucion.service';
import { GrupoComponent } from './grupo/grupo.component';
import { GrupoService } from './grupo/grupo.service';
import { InstitucionFormsComponent } from './Institucion/institucion-forms/institucion-forms.component';
import { CategoriaSubCategoriaService } from './institucion/categoria-sub-categoria.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CategoriaComponent,
    SubCategoriaComponent,
    InstitucionComponent,
    GrupoComponent,
    InstitucionFormsComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'Categoria', component: CategoriaComponent },
      { path: 'Grupo', component: GrupoComponent},
      { path: 'subCategoria', component: SubCategoriaComponent },
      { path: 'Institucion', component: InstitucionComponent },
      { path: 'Institucion', component: InstitucionComponent },
      { path: 'Agregar-Institucion', component: InstitucionFormsComponent },
      { path: 'Editar-institucion', component: InstitucionFormsComponent },


    
      

      
    
     
      
    ])
  ],
  providers: [CategoriaService, SubCategoriaService, InstitucionService, CategoriaSubCategoriaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
