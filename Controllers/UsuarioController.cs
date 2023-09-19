using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiUser.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiUser.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>
            {
                new Usuario {Id = 1, Nome = "Larissa", Idade = 24}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }

    }
}