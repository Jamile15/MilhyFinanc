
using Microsoft.AspNetCore.Mvc;
using MilhyFinancApi.Models;

namespace MilhyFinanc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        [HttpPost]
        public void NovoUsuario([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Senha);
            Console.WriteLine(usuario.Email);


        }
    }
}