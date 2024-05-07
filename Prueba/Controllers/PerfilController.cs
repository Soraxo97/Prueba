using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        // Lista estática de perfiles
        private static List<string> perfiles = new List<string> { "ADMIN", "VISUALIZADOR" };

        // GET: api/Perfil/ObtenerPerfiles
        [HttpGet("ObtenerPerfiles")]
        public IActionResult ObtenerPerfiles()
        {
            return Ok(perfiles);
        }
    }
}
