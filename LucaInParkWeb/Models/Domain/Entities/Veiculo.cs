namespace LucaInParkWeb.Models.Domain.Entities
{
    public class Veiculo
    {
        public string VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Duration { get; set; }
        public int CostFlag { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal PrecoFinal { get; set; }
        public bool Active { get; set; }

        public Veiculo()
        {
            VeiculoId = string.IsNullOrEmpty(VeiculoId) ? BaseEntity.GeneratorId() : string.Empty;
            Modelo = string.Empty;
            Placa = string.Empty;
            StartTime = DateTime.Now;
            EndTime = null;
            Duration = string.Empty;
            CostFlag = 0;
            Active = true;
            PrecoUnitario = 5.00m;
            PrecoFinal = 0.00m;
        }
    
    }
}
