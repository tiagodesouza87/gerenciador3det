using Microsoft.AspNetCore.Mvc;
using VantagensAPI.Models;

namespace VantagensAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VantagensController : ControllerBase
    {
        private List<Vantagem> listaVantagens = new List<Vantagem>();

        [HttpPost]
        public void IncluirVantagem([FromBody] Vantagem vantagem)
        {
            Console.WriteLine(vantagem);
            listaVantagens.Add(vantagem);
            Console.WriteLine(vantagem.Nome);
            Console.WriteLine(vantagem.Descricao);
        }

        [HttpGet]
        public IActionResult ConsultarVantagens()
        {
            return Ok(listaVantagens);
        }

        [HttpGet("{id}")]
        public IActionResult ConsultarVantagemPorId(int id)
        {
            return Ok(null);
        }


    }
}
