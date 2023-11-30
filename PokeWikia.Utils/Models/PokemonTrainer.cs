using PokeApiNet;

namespace PokeWikia.Utils.Models;

/// <summary>
/// Enum with all the trainer types
/// </summary>
public enum TrainerTypes
{
    CAMPER,
    LEADER_Brock,
    TEAMROCKET_M,
    TEAMROCKET_F,
    RIVAL1,
    CHAMPION,
    SWIMMER2_F,
    POKEMONTRAINER_May,
    COOLCOUPLE,
    LASS,
    BEAUTY,
    FISHERMAN,
    HIKER,
    PICNICKER,
    YOUNGSTER
}

/// <summary>
/// All the trainer information
/// </summary>
public class PokemonTrainer
{
    /// <summary>
    /// Name of the trainer
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Trainer type
    /// </summary>
    public TrainerTypes TrainerType { get; set; }

    /// <summary>
    /// Trainers pokemon team
    /// </summary>
    public List<Pokemon> Team { get; set; }

    /// <summary>
    /// Trainer custom sprite
    /// </summary>
    public string Sprite { get; set; }

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
}