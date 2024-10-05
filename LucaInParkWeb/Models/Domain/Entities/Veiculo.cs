namespace LucaInParkWeb.Models.Domain.Entities
{
    public class Veiculo
    {
        public string VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int CostFlag { get; set; }
        public bool Active { get; set; }

        public Veiculo()
        {
            VeiculoId = string.IsNullOrEmpty(VeiculoId) ? BaseEntity.GeneratorId() : string.Empty;
            Modelo = string.IsNullOrEmpty(Modelo) ? "" : string.Empty;
            Placa = string.IsNullOrEmpty(Placa) ? "" : string.Empty;
            EndTime = null;
            Duration = TimeSpan.Zero;
            CostFlag = 0;
        }
    
    }
}
