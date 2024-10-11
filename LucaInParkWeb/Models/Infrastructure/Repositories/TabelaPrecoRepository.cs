using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LucaInParkWeb.Models.Infrastructure.Repositories
{
    public class TabelaPrecoRepository : ITabelaPrecoRepository
    {
        private readonly ControleEstacionamentoContext context;

        public TabelaPrecoRepository(ControleEstacionamentoContext context)
        {
            this.context = context;
        }

        public async Task Create(TabelaPreco tabelaPreco)
        {
            await context.TabelaPrecos.AddAsync(tabelaPreco);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var preco = await GetTabelaPrecoId(id);
            if (preco != null && preco.Id.Equals(id))
                context.TabelaPrecos.Remove(preco);
            await context.SaveChangesAsync();
        }

        public async Task<List<TabelaPreco>> GetPrecoList()
        {
            return await context.TabelaPrecos.ToListAsync();
        }

        public async Task<TabelaPreco> GetTabelaPrecoId(int id)
        {
            return await context.TabelaPrecos.FindAsync(id);
        }
    }
}
