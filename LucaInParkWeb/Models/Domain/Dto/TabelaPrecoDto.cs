using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Domain.Dto
{
    public class TabelaPrecoDto
    {
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public decimal PrecoVigenciaInicial { get; set; }
        public decimal PrecoVigenciaAdicional { get; set; }

        public TabelaPrecoDto()
        { 
        }
        public TabelaPreco ConvertToEntity()
        {
            var tabelaPreco = new TabelaPreco();
            tabelaPreco.InicioVigencia = this.InicioVigencia;
            tabelaPreco.FimVigencia = this.FimVigencia;
            tabelaPreco.PrecoVigenciaInicial = this.PrecoVigenciaInicial;
            tabelaPreco.PrecoVigenciaAdicional = this.PrecoVigenciaAdicional;

            return tabelaPreco;
        }
    }
}
