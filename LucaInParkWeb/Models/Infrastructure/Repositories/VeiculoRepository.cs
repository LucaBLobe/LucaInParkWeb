using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LucaInParkWeb.Models.Infrastructure.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ControleEstacionamentoContext context;

        public VeiculoRepository(ControleEstacionamentoContext context)
        {
            this.context = context;
        }

        public async Task Create(Veiculo veiculo)
        {
            await context.Veiculos.AddAsync(veiculo);
            await context.SaveChangesAsync();
        }

        public async Task Delete(string veiculoId)
        {
            var veiculo = await Read(veiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculoId))
                context.Veiculos.Remove(veiculo);
                await context.SaveChangesAsync();
        }

        public async Task<Veiculo> Read(string veiculoId)
        {
            return await context.Veiculos.FindAsync(veiculoId);
        }

        public async Task<TabelaPreco> GetTabelaPreco(DateTime startDate)
        {

            return await context.TabelaPrecos.Where(p => p.InicioVigencia.Date <= startDate.Date && p.FimVigencia.Date >= startDate.Date).FirstOrDefaultAsync();
        }

        public async Task Update(Veiculo veiculo)
        {
            var veiculoAtualizado = await Read(veiculo.VeiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculo.VeiculoId))
            {
                veiculoAtualizado.Modelo = veiculo.Modelo;
                veiculoAtualizado.Placa = veiculo.Placa;
                veiculoAtualizado.EndTime = veiculo.EndTime;
                veiculoAtualizado.Duration = veiculo.Duration;
                veiculoAtualizado.Active = veiculo.Active;
                veiculoAtualizado.PrecoFinal = veiculo.PrecoFinal;

                context.Veiculos.Update(veiculo);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Veiculo>> VeiculoList()
        {
            return await context.Veiculos.ToListAsync();
        }
    }
}
