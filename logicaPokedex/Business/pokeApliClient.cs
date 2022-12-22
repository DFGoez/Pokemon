using Newtonsoft.Json;
using RestSharp;

namespace logicaPokedex.Business;

public class pokeApliClient
{
    private String endPoint;

    public pokeApliClient(String URL)
    {
        this.endPoint = URL;
    }
    private String execute(String id = null )
    {
        if (id != null)
        {
            this.endPoint = this.endPoint + id; 
        }


        RestClient client = new RestClient();
        RestRequest request = new RestRequest(this.endPoint, Method.Get);
        RestResponse response = client.Execute(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return response.Content;
        }
        else
        {
            return null;
        }
    }

}

