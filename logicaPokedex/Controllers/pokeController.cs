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
          pokeApliClient api = new pokeApliClient("https://pokeapi.co/api/v2/pokemon/");                                     
            return  api.execute(pokemon.id);                                   
        }


        [HttpPost("species")]
        public String getPokemonSpecies([FromBody] RequestModel pokemon)
        {
            pokeApliClient api = new pokeApliClient("https://pokeapi.co/api/v2/pokemon-species/") ;                                     
            return  api.execute(pokemon.id);                                   
        }


        [HttpPost("evolution")]                                  
        public String getPokemonEvolution([FromBody] RequestModel pokemon)
        {
          pokeApliClient api = new pokeApliClient(pokemon.url);                                     
            return  api.execute();                                   
        }

         [HttpPost("list")]
        public String getPokemonList([FromBody] RequestModel pokemon)
        {
          pokeApliClient api = new pokeApliClient(pokemon.url);                                     

            return  api.execute();                                   
        }

        [HttpPost("moves")]
        public string getPokemonMoves([FromBody] RequestModel pokemon)
        {
            pokeApliClient api = new pokeApliClient("https://pokeapi.co/api/v2/move/");

            return api.execute(pokemon.id);
        }
    }
}