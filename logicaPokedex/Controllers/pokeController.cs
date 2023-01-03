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
<<<<<<< HEAD
        public String getPokemonEvolution([FromBody] RequestModel endPoint)
        {
          pokeApliClient api = new pokeApliClient(endPoint.url);                                     
=======
        public String getPokemonEvolution([FromBody] RequestModel pokemon)
        {
          pokeApliClient api = new pokeApliClient(pokemon.url);                                     
            return  api.execute();                                   
        }
         [HttpPost("list")]
        public String getPokemonList([FromBody] RequestModel pokemon)
        {
          pokeApliClient api = new pokeApliClient(pokemon.url);                                     
>>>>>>> 17352a7964687423186f057d299cac8e48c833c0
            return  api.execute();                                   
        }

    }
}