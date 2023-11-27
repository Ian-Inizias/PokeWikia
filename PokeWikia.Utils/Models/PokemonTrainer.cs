using PokeApiNet;

namespace PokeWikia.Utils.Models;

public enum TrainerTypes
{
    GymLeader = 0,
    BugcatcherF = 1,
    BugcatcherM = 2,
    Grunt = 3,
    Camper = 4,
}

public class PokemonTrainer
{
    public string Name { get; set; }
    public TrainerTypes TrainerType { get; set; }
    public List<Pokemon> Team { get; set; }
    public string Sprite { get; set; }

    private static PokeApiClient _pokeApiClient = new();

    public PokemonTrainer()
    {
    }

    private PokemonTrainer(string name, TrainerTypes type, string sprite, List<Pokemon> team)
    {
        Name = name;
        TrainerType = type;
        Sprite = sprite;
        Team = team;
    }

    /// <summary>
    /// Builds a random trainer
    /// </summary>
    /// <param name="name">Name for the trainer</param>
    /// <returns>Pokemon trainer with 6 random pokemons</returns>
    public static async Task<PokemonTrainer> Build(string name)
    {
        Random rng = new();
        var team = new List<Pokemon>();
        var values = Enum.GetValues(typeof(TrainerTypes));
        var type = (TrainerTypes)(values.GetValue(rng.Next(values.Length)) ?? throw new InvalidOperationException());
        for (var i = 0; i < 6; i++)
        {
            team.Add(await _pokeApiClient.GetResourceAsync<Pokemon>(rng.Next(1, 1000)));
        }

        return new PokemonTrainer(name, type, team[0].Sprites.FrontDefault, team);
    }
}