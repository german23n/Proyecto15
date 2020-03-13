import { IGrupo } from "../grupo/Grupo";
import { ICategoria } from "../categoria/Categoria";
import { ISCategoria } from "../sub-categoria/SubCategoria";

export interface Iinstitucion {
    id: number;
  idInstitucion: number;
  razonSocial: string;
  alias: string;
  idGrupo: IGrupo;
  idCSC: ICSC;



}

export interface ICSC {
  IdCSC: number;
  idCategoria: ICategoria;
  idSubCategoria: ISCategoria;
}
