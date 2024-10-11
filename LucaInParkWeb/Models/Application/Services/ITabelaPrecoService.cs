using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Application.Services
{
    public interface ITabelaPrecoService
    {
        Task Create(TabelaPreco tabelaPreco);
        Task<List<TabelaPreco>> GetTapbelaPrecoList();
        Task Delete(int id);
        Task<TabelaPreco> GetTabelaPrecoId(int id);
    }
}
