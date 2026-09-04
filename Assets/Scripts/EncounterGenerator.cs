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
    //[Header(""References"")]
    //[Header(""Input"")]
    //[Header(""Output"")]

    public abstract void DecideRandomEncounter(); 
}