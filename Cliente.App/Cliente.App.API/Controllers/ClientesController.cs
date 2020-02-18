using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Cliente.Business.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [ResponseType(typeof(IList<DTO.Clientes.ClienteViewModel>))]
        public IActionResult GetClientes(string filtro)
        {
            try
            {
                var bs = new Business.ClienteBusiness();
                var lista = bs.GetClientes(filtro);

                if (lista.Count == 0)
                    return NoContent();

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar os clientes: '{ex.Message}'");
            }
        }

        [HttpGet]
        [Route("{id}")]
        [ResponseType(typeof(DTO.Clientes.Cidade))]
        public IActionResult GetCliente(int id)
        {
            try
            {
                var bs = new Business.ClienteBusiness();
                var lista = bs.GetCliente(id);

                if (lista == null)
                    return NoContent();

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar o cliente: '{ex.Message}'");
            }
        }

        [HttpPost]
        [Route("Salvar")]
        public IActionResult SalvarCliente(DTO.Clientes.Cliente cliente)
        {
            try
            {
                var bs = new Business.ClienteBusiness();
                bs.SalvarCliente(cliente);

                return Ok("Cliente salvo com sucesso!");
            }
            catch (ValidationException vlEx)
            {
                return BadRequest(vlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao salvar o cliente: '{ex.Message}'");
            }
        }

        [HttpDelete]
        [Route("Excluir")]
        public IActionResult ExcluirCliente(int id)
        {
            try
            {
                var bs = new Business.ClienteBusiness();
                bs.ExcluirCliente(id);

                return Ok("Cliente excluído com sucesso!");
            }
            catch (ValidationException vlEx)
            {
                return BadRequest(vlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao excluir o cliente: '{ex.Message}'");
            }
        }
    }
}