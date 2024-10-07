using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Domain.Dto
{
    public class VeiculoDto
    {
      //  public string VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
       // public DateTime StartTime { get; set; }
       // public DateTime? EndTime { get; set; }
        //public TimeSpan? Duration { get; set; }
       // public string Duration { get; set; }
       // public int CostFlag { get; set; }
       // public decimal PrecoUnitario { get; set; }
       // public decimal PrecoFinal { get; set; }
       // public bool Active { get; set; }

        public VeiculoDto() 
        {
        //    VeiculoId = string.IsNullOrEmpty(VeiculoId) ? BaseEntity.GeneratorId() : string.Empty;
        //    Modelo = string.Empty;
        //    Placa = string.Empty;
        //    EndTime = null;
        //    Duration = string.Empty;
        //    CostFlag = 0;
        //    Active = true;
        //    PrecoUnitario = 5.00m;
        //    PrecoFinal = 0.00m;
        }        
        
        public Veiculo ConvertToEntity() 
        { 
            var veiculoEstacionado = new Veiculo();
           // veiculoEstacionado.VeiculoId = !string.IsNullOrEmpty(this.VeiculoId) ? this.VeiculoId : BaseEntity.GeneratorId();
            veiculoEstacionado.Modelo = this.Modelo;
            veiculoEstacionado.Placa = this.Placa;   
          //  veiculoEstacionado.StartTime = this.StartTime;
          //  veiculoEstacionado.EndTime = null;
          //  veiculoEstacionado.Duration = this.Duration;
           // veiculoEstacionado.Active = this.Active; 
           // veiculoEstacionado.CostFlag = this.CostFlag;
           // veiculoEstacionado.PrecoFinal = this.PrecoFinal;
           // veiculoEstacionado.PrecoUnitario = this.PrecoUnitario;

            return veiculoEstacionado;
        }
    }
}
