﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        [HttpGet]
        [ResponseType(typeof(IList<DTO.Clientes.Estado>))]
        public IActionResult GetEstados()
        {
            try
            {
                var bs = new Business.EstadoBusiness();
                var lista = bs.GetEstados();

                if (lista.Count == 0)
                    return NoContent();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar os estados: '{ex.Message}'");
            }
        }
    }
}