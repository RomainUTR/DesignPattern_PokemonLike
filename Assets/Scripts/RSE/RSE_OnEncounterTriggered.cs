using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "RSE_OnEncounterTriggered", menuName = "Events/RSE_OnEncounterTriggered")]
public class RSE_OnEncounterTriggered : ScriptableObject
{
    public event UnityAction<IEncounter> OnEventRaised;

    public void Raise(IEncounter encounter)
    {
        OnEventRaised?.Invoke(encounter);
    }
}