export class Movimiento {
     idMovimiento:string;
    valor:number;
    detalle:string;
    fecha:Date;
   idUsuario:string;
}

export class MovimientoReponse
{
    movimientos:Movimiento[];
    total:number; 
}
