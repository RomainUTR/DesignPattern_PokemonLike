using System;
using System.Collections.Generic;
using UnityEngine;

public class PokedexManager : MonoBehaviour
{
    [SerializeField] private List<SSO_PokemonData> PokedexData = new List<SSO_PokemonData>();
    [SerializeField] private RSE_OnPokemonCapture OnPokemonCapture;

    private void OnEnable()
    {
        if (OnPokemonCapture != null)
        {
            OnPokemonCapture.OnEventRaised += HandleCapture;
        }
    }

    private void OnDisable()
    {
        if (OnPokemonCapture != null)
        {
            OnPokemonCapture.OnEventRaised -= HandleCapture;
        }
    }

    private void HandleCapture(SSO_PokemonData pokemonData)
    {
        if (!PokedexData.Contains(pokemonData))
        {
            PokedexData.Add(pokemonData);
            Debug.Log($"Pokémon découvert ! {pokemonData.name} ajouté à votre Pokédex !");
        }
        else
        {
            Debug.Log("Ce Pokémon est déjà connu. Ajout annulé.");
        }
    }
}