using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Domain.Dto
{
    public class VeiculoDto
    {
        public string VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int CostFlag { get; set; }
        public bool Active { get; set; }

        public VeiculoDto() 
        { 
        
        }        
        
        public Veiculo ConvertToEntity() 
        { 
            var veiculoEstacionado = new Veiculo();
            veiculoEstacionado.VeiculoId = !string.IsNullOrEmpty(this.VeiculoId) ? this.VeiculoId : BaseEntity.GeneratorId();
            veiculoEstacionado.Modelo = this.Modelo;
            veiculoEstacionado.Placa = this.Placa;   
            veiculoEstacionado.StartTime = this.StartTime;
            veiculoEstacionado.EndTime = this.EndTime;
            veiculoEstacionado.Duration = this.Duration;
            veiculoEstacionado.Active = this.Active; 
            veiculoEstacionado.CostFlag = this.CostFlag;

            return veiculoEstacionado;
        }
    }
}
