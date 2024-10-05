using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Repositories;

namespace LucaInParkWeb.Models.Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
        public async Task Create(Veiculo veiculo)
        {
            try
            {
                await _veiculoRepository.Create(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(string veiculoId)
        {
            try
            {
                await _veiculoRepository.Delete(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Veiculo> Read(string veiculo)
        {
            try
            {
               return await _veiculoRepository.Read(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(Veiculo veiculo)
        {
            try
            {
                await _veiculoRepository.Update(veiculo);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public async Task<List<Veiculo>> VeiculoList(Veiculo veiculo)
        {
            try
            {
                return await _veiculoRepository.VeiculoList(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task Checkout(Veiculo veiculo)
        {
            try
            {
                if (veiculo.Active.Equals(true))
                {
                    veiculo.EndTime = DateTime.Now;
                    veiculo.Duration = (TimeSpan)(veiculo.EndTime - veiculo.StartTime);
                    veiculo.CostFlag = (veiculo.Duration.Days * 24) + veiculo.Duration.Hours;
                    if (veiculo.Duration.Minutes > 10)
                    {
                        veiculo.CostFlag = veiculo.CostFlag + 1;
                    }
                    veiculo.Active = false;
                    await _veiculoRepository.Update(veiculo); 
                } 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
