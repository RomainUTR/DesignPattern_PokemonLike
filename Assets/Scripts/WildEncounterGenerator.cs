using RomainUTR.SLToolbox;
using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    public SSO_PokemonData[] PokemonDatas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Encounter Zone : " + EncounterType);
        if (collision.CompareTag("Player"))
        {
            DecideRandomEncounter();
        }
    }

    public override void DecideRandomEncounter()
    {
        Debug.Log(PokemonDatas.GetRandom().Name);
    }
}