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
    public class MunicipioController : ControllerBase
    {
        [HttpGet]
        [ResponseType(typeof(IList<DTO.Clientes.Municipio>))]
        public IActionResult GetMunicipios(string uf)
        {
            var bs = new Business.MunicipioBusiness();
            var lista = bs.GetMunicipios(uf);

            if (lista.Count == 0)
                return NoContent();

            return Ok();
        }
    }
}