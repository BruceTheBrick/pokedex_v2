namespace PokeDexBackend.Models
{
    public class Pokemon
    {
        public List<PokemonAbility> Abilities { get; set; }
        public int BaseExperience { get; set; }
        public Cries Cries { get; set; }
        public List<Form> Forms { get; set; }
        public List<object> GameIndices { get; set; }
        public int Height { get; set; }
        public List<object> HeldItems { get; set; }
        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public string LocationAreaEncounters { get; set; }
        public List<PokemonMove> Moves { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<object> PastAbilities { get; set; }
        public List<object> PastTypes { get; set; }
        public Species Species { get; set; }
        public Sprites Sprites { get; set; }
        public List<PokemonStat> Stats { get; set; }
        public List<PokemonType> Types { get; set; }
        public int Weight { get; set; }
    }
}