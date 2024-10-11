using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Infrastructure.Repositories
{
    public interface ITabelaPrecoRepository
    {
        Task Create(TabelaPreco tabelaPreco);
        Task Delete(int tabelaPreco);
        Task<List<TabelaPreco>> GetPrecoList();
        Task<TabelaPreco> GetTabelaPrecoId(int id);
    }
}
