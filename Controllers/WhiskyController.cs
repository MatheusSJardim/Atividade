using Atividade2.Model;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Atividade2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhiskyController : ControllerBase
    {
        private static List<Whisky> whiskys = new List<Whisky>();

        [HttpPost]
        public void AdicionarWhisky([FromBody] Whisky whisky)
        {
            whiskys.Add(whisky);
            Console.WriteLine(whisky.Id);
        }

        [HttpGet]
        public IActionResult getWhisky()
        {
            return Ok(whiskys);
        }

        [HttpGet("{Id}")]
        public IActionResult getWhiskyById(int id)
        {
            Whisky whisky = whiskys.FirstOrDefault(whisky => whisky.Id == id);
            if (whisky != null)
            {
                return Ok(whisky);
            }

            return BadRequest();
        }

    }
}