using System;
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
    public class EstadoController : ControllerBase
    {
        [HttpGet]
        [ResponseType(typeof(IList<DTO.Clientes.Estado>))]
        public IActionResult GetEstados()
        {
            var bs = new Business.EstadoBusiness();
            
            return Ok(bs.GetEstados());
        }
    }
}