using System.Numerics;
using System;

namespace LucaInParkWeb.Models.Domain.Entities
{
    public class TabelaPreco
    {
        public int Id { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public decimal PrecoVigenciaInicial { get; set; }
        public decimal PrecoVigenciaAdicional { get; set; }

        public TabelaPreco()
        {

        }

    }
}
