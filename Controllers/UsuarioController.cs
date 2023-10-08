
using Microsoft.AspNetCore.Mvc;
using MilhyFinancApi.Models;

namespace MilhyFinanc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        private static int id = 0;
        [HttpPost]
        public void NovoUsuario([FromBody] Usuario usuario)
        {
            usuario.Id = id++;
            usuarios.Add(usuario);
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Senha);
            Console.WriteLine(usuario.Email);

        }
        [HttpGet]
        public List<Usuario> ListaUsuarios()
        {
            return usuarios;
        }

    }



}