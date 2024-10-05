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
        }

        public async Task<Veiculo> Read(string veiculoId)
        {
            return await context.Veiculos.FirstOrDefaultAsync(v => v.VeiculoId.Equals(veiculoId));
        }

        public async Task Update(Veiculo veiculo)
        {
            var veiculoAtualizado = await Read(veiculo.VeiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculo.VeiculoId))
            {
                context.Veiculos.Update(veiculo);
            }
        }

        public async Task<List<Veiculo>> VeiculoList(Veiculo veiculo)
        {
            return await context.Veiculos.ToListAsync();
        }
    }
}
