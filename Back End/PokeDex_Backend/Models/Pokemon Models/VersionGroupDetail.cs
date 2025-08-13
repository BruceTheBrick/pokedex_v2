namespace PokeDexBackend.Models;

public class VersionGroupDetail
{
    public int LevelLearnedAt { get; set; }
    public MoveLearnMethod MoveLearnMethod { get; set; }
    public object Order { get; set; }
    public VersionGroup VersionGroup { get; set; }
}