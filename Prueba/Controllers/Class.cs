using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using System;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioPerfilController : ControllerBase
    {
        [HttpPost("RegistrarUsuario")]
        public IActionResult RegistrarUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (string.IsNullOrEmpty(usuario.NombreUsuario))
            {
                return BadRequest("El nombre de usuario es obligatorio.");
            }

            if (string.IsNullOrEmpty(usuario.Password))
            {
                return BadRequest("La contraseña es obligatoria.");
            }


            return Ok("Usuario registrado correctamente.");
        }
    }
}
