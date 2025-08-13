namespace PokeDexBackend.Models;

public class PokemonMove
{
    public Move Move { get; set; }
    public List<VersionGroupDetail> VersionGroupDetails { get; set; }
}