using UnityEngine;

public enum EncounterType
{
    Wild,
    Trainer,
    Random
}

public abstract class EncounterGenerator : MonoBehaviour
{
    [Header("Settings")]
    public EncounterType EncounterType;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Encounter Zone : " + EncounterType);
        if (collision.CompareTag("Player"))
        {
            IEncounter currentEncounter = CreateEncounter(EncounterType);
        }
    }
    
    protected abstract IEncounter CreateEncounter(EncounterType encounterType);
}