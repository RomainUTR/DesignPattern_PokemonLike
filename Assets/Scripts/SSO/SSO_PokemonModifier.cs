using UnityEngine;
public abstract class SSO_PokemonModifier : ScriptableObject
{
    public abstract IPokemonData Decorate(IPokemonData pokemonToWrap);    
}