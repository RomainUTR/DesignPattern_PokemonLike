using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "RSE_OnPokemonCapture", menuName = "Events/RSE_OnPokemonCapture")]
public class RSE_OnPokemonCapture : ScriptableObject
{
    public event UnityAction<SSO_PokemonData> OnEventRaised;

    public void Raise(SSO_PokemonData data)
    {
        OnEventRaised?.Invoke(data);
    }
}