export class Movimiento {
     IdMovimiento:string;
    valor:number;
    Detalle:string;
    Fecha:Date;
   IdUsuario:string;
}

export class MovimientoReponse
{
    movimientos:Movimiento[];
    total:number; 
}
