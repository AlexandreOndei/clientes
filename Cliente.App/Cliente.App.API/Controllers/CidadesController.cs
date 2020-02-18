using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        [HttpGet]
        [ResponseType(typeof(IList<DTO.Clientes.Cidade>))]
        public IActionResult GetCidades(string uf)
        {
            try
            {
                var bs = new Business.CidadeBusiness();
                var lista = bs.GetCidades(uf);

                if (lista.Count == 0)
                    return NoContent();

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar as cidades: '{ex.Message}'");
            }
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult AdicionarCidade(DTO.Clientes.Cidade cidade)
        {
            try
            {
                var bs = new Business.CidadeBusiness();
                bs.AdicionarCidade(cidade);

                return Ok("Cidade adicionada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar a cidade: '{ex.Message}'");
            }
        }
    }
}