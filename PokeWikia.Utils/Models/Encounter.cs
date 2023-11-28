using PokeApiNet;

namespace PokeWikia.Utils.Models;

public enum EncounterTypes
{
    Land,
    LandMorning,
    LandNight,
    BugContest,
    Water,
    WaterNight,
    OldRod,
    GoodRod,
    SuperRod,
    Cave,
    HeadbuttLow,
    HeadbuttHigh,
    RockSmash,
}

public class Encounters
{
    public string RouteId { get; set; }
    public List<WildEncounter> WildEncounters { get; set; }
}

public class WildEncounter
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