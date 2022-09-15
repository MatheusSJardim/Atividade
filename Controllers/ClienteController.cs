using Atividade2.Model;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Atividade2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> Clientes = new List<Cliente>();

        [HttpPost]
        public void AdicionarCliente([FromBody] Cliente Cliente)
        {
            Clientes.Add(Cliente);
            Console.WriteLine(Cliente.Id);
        }

        [HttpGet]
        public IActionResult getCliente()
        {
            return Ok(Clientes);
        }

        [HttpGet("{Id}")]
        public IActionResult getClienteById(int id)
        {
            Cliente Cliente = Clientes.FirstOrDefault(Cliente => Cliente.Id == id);
            if (Cliente != null)
            {
                return Ok(Cliente);
            }

            return BadRequest();
        }

    }
}
