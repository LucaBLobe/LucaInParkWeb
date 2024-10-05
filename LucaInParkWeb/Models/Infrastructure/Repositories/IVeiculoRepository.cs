using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Infrastructure.Repositories
{
    public interface IVeiculoRepository
    {
        Task Create(Veiculo veiculo);
        Task Update(Veiculo veiculo);
        Task<List<Veiculo>> VeiculoList(Veiculo veiculo);
        Task Delete(string veiculo);
        Task<Veiculo> Read(string veiculo);
    }
}
