import { IGrupo } from "../grupo/Grupo";

export interface Iinstitucion {
    id: number;
  idInstitucion: number;
  razonSocial: string;
  alias: string;
  idGrupo: IGrupo;
  idCSC: number;



}
