using RomainUTR.SLToolbox;
using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    public SSO_PokemonData[] PokemonDatas;

    [Range(0f, 100f)] public float ShinyChancePercentage = 1f;

    [Header("Events")]
    public RSE_OnPokemonCapture CaptureEvent;
    public RSE_OnShinyFound ShinyEvent;

    protected override IEncounter CreateEncounter(SSO_PokemonData playerPokemon)
    {
        SSO_PokemonData drawnPokemon = PokemonDatas.GetRandom();
        bool isShiny = Random.Range(0f, 100f) <= ShinyChancePercentage;
        
        return new WildEncounter(drawnPokemon, isShiny, playerPokemon, CaptureEvent, ShinyEvent);
    }
}