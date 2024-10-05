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
        [Route("Checkout")]
        public async Task<string> Update([FromBody] VeiculoDto veiculo)
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
        
        [HttpGet]
        [Route("List")]
        public async Task<List<Veiculo>> VeiculoList(Veiculo veiculo)
        {
            try
            {
                return await _veiculoService.VeiculoList(veiculo);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
