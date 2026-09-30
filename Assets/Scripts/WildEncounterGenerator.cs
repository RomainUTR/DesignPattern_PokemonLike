using RomainUTR.SLToolbox;
using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    public SSO_PokemonData[] PokemonDatas;

    [Range(0f, 100f)] public float ShinyChancePercentage = 1f;

    protected override IEncounter CreateEncounter(EncounterType encounterType)
    {
        SSO_PokemonData drawnPokemon = PokemonDatas.GetRandom();
        bool isShiny = Random.Range(0f, 100f) <= ShinyChancePercentage;
        Debug.Log("Pokémon sauvage pioché : " + drawnPokemon.Name);
        
        return new WildEncounter(drawnPokemon, isShiny);
    }
}