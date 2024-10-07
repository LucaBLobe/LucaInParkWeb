using LucaInParkWeb.Models.Domain.Entities;

namespace LucaInParkWeb.Models.Application.Services
{
    public interface IVeiculoService
    {
        Task Create(Veiculo veiculo);
        Task Update(Veiculo veiculo);
        Task Checkout(Veiculo veiculo);
        Task<List<Veiculo>> VeiculoList();
        Task Delete(string veiculo);
        Task<Veiculo> Read(string veiculoId);

    }
}
