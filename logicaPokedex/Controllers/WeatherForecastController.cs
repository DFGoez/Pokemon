using Microsoft.AspNetCore.Mvc;

namespace logicaPokedex.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost("pokemon")]
        public String getPokemon(String id)
        {
          pokeApiClient api = new pokeApiClient("https://pokeapi.co/api/v2/pokemon/") ;                                     
            return  api.execute(id);                                   
        } 


        [HttpPost("species")]
        public String getPokemonSpecies(String endPoint)
        {
          pokeApiClient api = new pokeApiClient(endPoint) ;                                     
            return  api.execute();                                   
        }


        [HttpPost("evolution")]
        public String getPokemonEvolution(String endPoint)
        {
          pokeApiClient api = new pokeApiClient(endPoint);                                     
            return  api.execute();                                   
        }

    }
}