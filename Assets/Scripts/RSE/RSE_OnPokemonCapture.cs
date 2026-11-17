using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "RSE_OnPokemonCapture", menuName = "Events/RSE_OnPokemonCapture")]
public class RSE_OnPokemonCapture : ScriptableObject
{
    public event UnityAction<IPokemonData> OnEventRaised;

    public void Raise(IPokemonData data)
    {
        OnEventRaised?.Invoke(data);
    }
}