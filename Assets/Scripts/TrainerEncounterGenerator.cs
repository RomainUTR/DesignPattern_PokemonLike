using RomainUTR.SLToolbox;
using UnityEngine;

public class TrainerEncounterGenerator : EncounterGenerator
{
    public SSO_TrainerData[] TrainerDatas;

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
        Debug.Log(TrainerDatas.GetRandom().Name);
    }
}