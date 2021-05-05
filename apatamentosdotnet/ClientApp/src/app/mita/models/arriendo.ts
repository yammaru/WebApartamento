import { Cliente } from "./cliente";
import { Movimiento } from "./movimiento";

export class Arriendo {
    idArriendo:string;
    fechaIngreso: Date ;
    fechaDesalojo:Date;
    total:number;
    idCliente:string;
    cliente: Cliente;
    idApartamento: string;
    movimineto:Movimiento;
}
