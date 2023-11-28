using PokeApiNet;

namespace PokeWikia.Utils.Models;

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

public class PokemonTrainer
{
    public string Name { get; set; }
    public TrainerTypes TrainerType { get; set; }
    public List<Pokemon> Team { get; set; }
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