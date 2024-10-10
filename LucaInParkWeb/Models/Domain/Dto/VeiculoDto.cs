using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Domain.Dto
{
    public class VeiculoDto
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public VeiculoDto() 
        {

        }        
        
        public Veiculo ConvertToEntity() 
        { 
            var veiculoEstacionado = new Veiculo();
            veiculoEstacionado.Modelo = this.Modelo;
            veiculoEstacionado.Placa = this.Placa;   

            return veiculoEstacionado;
        }
    }
}
