using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AlbumFigurinhas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigurinhaController : ControllerBase
    { 
        public List<Figurinha> listaFigutinha = new List<Figurinha>()
        {
            new Figurinha(1, "Cristiano Ronaldo", "Seleção Portuguesa", 7),
            new Figurinha(2, "Neymar da Silva Santos Júnior", "Seleção Brasileira", 10),
            new Figurinha(3, "Lionel Messi", "Seleção Argentina", 10),
        };

        [HttpGet]
        public List<Figurinha> Get()
        {
            return listaFigutinha;
        }

        [HttpGet]
        [Route ("{numerocarta}")]
        public Figurinha GetPorNumeroCarta(int numerocarta)
        {
            var figurinhaBuscada = listaFigutinha.Find(f => f.NumeroCarta == numerocarta);
            return figurinhaBuscada;
        }

        [HttpPost]
        public List<Figurinha> Post([FromBody] Figurinha novaFigurinha)
        {
            listaFigutinha.Add(novaFigurinha);
            return listaFigutinha;
        }

        [HttpPut]
        public List<Figurinha> Put([FromBody] Figurinha figurinhaEditada)
        {
            var figurinhaBuscada = listaFigutinha.Find(f => f.NumeroCarta == figurinhaEditada.NumeroCarta);
            
            figurinhaBuscada.NumeroCarta = figurinhaEditada.NumeroCarta;
            figurinhaBuscada.NomeJogador = figurinhaEditada.NomeJogador;
            figurinhaBuscada.Selecao = figurinhaEditada.Selecao;
            figurinhaBuscada.NumeroCamisa = figurinhaEditada.NumeroCamisa;

            return listaFigutinha;
        }
        
        [HttpDelete]
        public List<Figurinha> Delete([FromBody] Figurinha figurinhaDelete)
        {
            var figurinhaBuscada = listaFigutinha.Find(f => f.NumeroCarta == figurinhaDelete.NumeroCarta);

            listaFigutinha.Remove(figurinhaBuscada);
            return listaFigutinha;
        }
    }
}