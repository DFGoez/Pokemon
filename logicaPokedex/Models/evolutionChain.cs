
public class RootobjectEvolutionChain
{
    public object baby_trigger_item { get; set; }
    public Chain chain { get; set; }
    public int id { get; set; }
}

public class Chain
{
    public object[] evolution_details { get; set; }
    public object[] evolves_to { get; set; }
    public bool is_baby { get; set; }
    public Species species { get; set; }
}

public class SpeciesEvolutionChain
{
    public string name { get; set; }
    public string url { get; set; }
}

