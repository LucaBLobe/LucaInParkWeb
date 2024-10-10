using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Repositories;
using System;

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
                var startDate = veiculo.StartTime;
                var vigencia = await _veiculoRepository.GetTabelaPreco(startDate);
                veiculo.PrecoUnitario = vigencia.PrecoVigencia;
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

        public async Task<Veiculo> Read(string veiculoId)
        {
            try
            {
               return await _veiculoRepository.Read(veiculoId);
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

        public async Task<List<Veiculo>> VeiculoList()
        {
            try
            {
                return await _veiculoRepository.VeiculoList();
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
                    var duration = new TimeSpan(0, 0, 0, 0);
                    duration = (TimeSpan)(veiculo.EndTime - veiculo.StartTime);
                    veiculo.CostFlag = (duration.Days * 24) + duration.Hours;
                    if (duration.TotalMinutes <= 30)
                    {
                        veiculo.PrecoFinal = veiculo.PrecoUnitario / 2;
                        veiculo.CostFlag = 0;
                    }else if(duration.Minutes >= 10)
                    {
                        veiculo.CostFlag = veiculo.CostFlag + 1;
                        veiculo.PrecoFinal = veiculo.PrecoUnitario * veiculo.CostFlag;
                    }
                    else
                    {
                        veiculo.PrecoFinal = veiculo.PrecoUnitario * veiculo.CostFlag;
                    }
                    var durationString = duration.ToString(@"dd\.hh\:mm\:ss");
                    veiculo.Duration = durationString;
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
