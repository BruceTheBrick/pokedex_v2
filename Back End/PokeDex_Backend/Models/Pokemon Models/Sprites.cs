namespace PokeDexBackend.Models;

public class Sprites
{
    public string BackDefault { get; set; }
    public string BackFemale { get; set; }
    public string BackShiny { get; set; }
    public string BackShinyFemale { get; set; }
    public string FrontDefault { get; set; }
    public string FrontFemale { get; set; }
    public string FrontShiny { get; set; }
    public string FrontShinyFemale { get; set; }
    public OtherSprites Other { get; set; }
}