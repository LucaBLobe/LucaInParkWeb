using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Domain.Dto
{
    public class TabelaPrecoDto
    {
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public string PrecoVigenciaInicial { get; set; }
        public string PrecoVigenciaAdicional { get; set; }

        public TabelaPrecoDto()
        { 
        }
        public TabelaPreco ConvertToEntity()
        {
            var tabelaPreco = new TabelaPreco();
            tabelaPreco.InicioVigencia = this.InicioVigencia;
            tabelaPreco.FimVigencia = this.FimVigencia;
            tabelaPreco.PrecoVigenciaInicial = 0.00m;

            return tabelaPreco;
        }
    }
}
