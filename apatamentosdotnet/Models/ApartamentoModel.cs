using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class ApartamentoInputModel
    {
        public string IdApartamento { get; set; }
        public int ValorApartamento { get; set; }
        public int Deposito { get; set; }
        public string Estado { get; set; }
    }

    public class ApartamentoViewModel : ApartamentoInputModel
    {
        public ApartamentoViewModel()
        {

        }
        public ApartamentoViewModel(Apartamento apartamento)
        {
            IdApartamento = apartamento.IdApartamento;
            ValorApartamento = apartamento.ValorApartamento;
            Deposito = apartamento.Deposito;
            Estado = apartamento.Estado;
        }

    }
}