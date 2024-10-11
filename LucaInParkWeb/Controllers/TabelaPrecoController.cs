using LucaInParkWeb.Models.Application.Services;
using LucaInParkWeb.Models.Domain.Dto;
using LucaInParkWeb.Models.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LucaInParkWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TabelaPrecoController : ControllerBase
    {
        private readonly ITabelaPrecoService _tabelaPrecoService;
        public TabelaPrecoController(ITabelaPrecoService tabelaPrecoService)
        {
            _tabelaPrecoService = tabelaPrecoService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<string> Create([FromBody] TabelaPrecoDto tabelaPreco)
        {
            try
            {
                var entity = tabelaPreco.ConvertToEntity();
                await _tabelaPrecoService.Create(entity);
                return "parametrizado com sucesso";
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("List")]
        public async Task<List<TabelaPreco>> GetPrecoList()
        {
            try
            {
                return await _tabelaPrecoService.GetTapbelaPrecoList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public async Task<string> Delete(int id)
        {
            try
            {
                await _tabelaPrecoService.Delete(id);
                return "tabela de preço excluida";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetPreco/{id}")]
        public async Task<TabelaPreco> GetPrecoId(int id)
        {
            try
            {
                return await _tabelaPrecoService.GetTabelaPrecoId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
