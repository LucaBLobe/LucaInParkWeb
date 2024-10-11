using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Repositories;

namespace LucaInParkWeb.Models.Application.Services
{
    public class TabelaPrecoService : ITabelaPrecoService
    {
        public readonly ITabelaPrecoRepository _tabelaPrecoRepository;
        public TabelaPrecoService(ITabelaPrecoRepository tabelaPrecoRepository)
        {
            _tabelaPrecoRepository = tabelaPrecoRepository;
        }
        public async Task Create(TabelaPreco tabelaPreco)
        {
            try
            {
                await _tabelaPrecoRepository.Create(tabelaPreco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                await _tabelaPrecoRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TabelaPreco> GetTabelaPrecoId(int id)
        {
            try
            {
                return await _tabelaPrecoRepository.GetTabelaPrecoId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TabelaPreco>> GetTapbelaPrecoList()
        {
            try
            {
                return await _tabelaPrecoRepository.GetPrecoList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

