using RomainUTR.SLToolbox;
using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    public ScriptableObject[] PokemonDatas;

    [Range(0f, 100f)] public float ShinyChancePercentage = 1f;

    [Header("Events")]
    public RSE_OnPokemonCapture CaptureEvent;
    public RSE_OnShinyFound ShinyEvent;

    private void OnValidate()
    {
        if (PokemonDatas == null) return;

        for (int i = 0; i < PokemonDatas.Length; i++)
        {
            if (PokemonDatas[i] != null && PokemonDatas[i] is not IPokemonData)
            {
                Debug.LogError($"[Adapter Error] {PokemonDatas[i].name} n'implémente pas IPokemonData ! Glisse un SSO_PokemonData ou un SSO_Gen2ToGen1PokemonAdapter.");
                PokemonDatas[i] = null;
            }
        }
    }

    protected override IEncounter CreateEncounter(IPokemonData playerPokemon)
    {
        IPokemonData drawnPokemon = PokemonDatas.GetRandom() as IPokemonData;
        bool isShiny = Random.Range(0f, 100f) <= ShinyChancePercentage;
        
        return new WildEncounter(drawnPokemon, isShiny, playerPokemon, CaptureEvent, ShinyEvent);
    }
}