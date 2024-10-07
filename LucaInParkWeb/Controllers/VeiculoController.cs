using LucaInParkWeb.Models.Application.Services;
using LucaInParkWeb.Models.Domain.Dto;
using LucaInParkWeb.Models.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LucaInParkWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<string> Create([FromBody] VeiculoDto veiculo)
        {
            try
            {
                var entity = veiculo.ConvertToEntity();
                await _veiculoService.Create(entity);
                return "Confirmado novo estacionamento.";
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        } 

        [HttpPut]
        [Route("Checkout/{id}")]
        public async Task<string> Checkout(string id)
        {
            try
            {
                var veiculoRepository = await _veiculoService.Read(id);
                await _veiculoService.Checkout(veiculoRepository);
                return "Checkout Realizado.";
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        } 
        
        [HttpGet]
        [Route("List")]
        public async Task<List<Veiculo>> VeiculoList()
        {
            try
            {
                return await _veiculoService.VeiculoList();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("DeleteById/{id}")]
        public async Task<string> Delete(string id)
        {
            try
            {
                
                await _veiculoService.Delete(id);
                return "vaga excluida";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Read/{id}")]
        public async Task<Veiculo> Read(string id)
        {
            try
            {
                return await _veiculoService.Read(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
