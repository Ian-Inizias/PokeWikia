using PokeApiNet;

namespace PokeWikia.Utils.Models;

public enum EncounterTypes
{
    Land,
    LandNight,
    Water,
    WaterNight,
    OldRod,
    GoodRod,
    SuperRod
}

public class Encounters
{
    public string RouteId { get; set; }
    public List<Encounter> WildEncounters { get; set; }
}

public class Encounter
{
    public int Frequency { get; set; }
    public EncounterTypes EncounterType { get; set; }
    public List<EncounterRatio> EncounterRatios { get; set; }
}

public class EncounterRatio
{
    public int Rate { get; set; }
    public Pokemon Pokemon { get; set; }
    public int[] Levels { get; set; }
}