using RomainUTR.SLToolbox;
using UnityEngine;

public class TrainerEncounterGenerator : EncounterGenerator
{
    public SSO_TrainerData[] TrainerDatas;

    protected override IEncounter CreateEncounter(IPokemonData pokemonData)
    {
        SSO_TrainerData drawnTrainer = TrainerDatas.GetRandom();
        Debug.Log("Dresseur pioché : " + drawnTrainer.Name);
        
        return new TrainerEncounter(drawnTrainer, pokemonData);
    }
}