using logicaPokedex.Business;
using logicaPokedex.Models;
using Microsoft.AspNetCore.Mvc;


namespace logicaPokedex.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class pokeController : ControllerBase
    {

       [HttpPost("pokemon")]
        public String getPokemon([FromBody] RequestModel pokemon)
        {
          pokeApliClient api = new pokeApliClient("https://pokeapi.co/api/v2/pokemon/") ;                                     
            return  api.execute(pokemon.id);                                   
        }


        [HttpPost("species")]
        public String getPokemonSpecies([FromBody] RequestModel pokemon)
        {
            pokeApliClient api = new pokeApliClient("https://pokeapi.co/api/v2/pokemon-species/") ;                                     
            return  api.execute(pokemon.id);                                   
        }


        [HttpPost("evolution")]
        public String getPokemonEvolution([FromBody] SpeciesRoot endPoint)
        {
          pokeApliClient api = new pokeApliClient(endPoint.evolution_chain.url);                                     
            return  api.execute();                                   
        }

    }
}