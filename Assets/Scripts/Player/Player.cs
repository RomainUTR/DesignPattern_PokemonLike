using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ScriptableObject _playerPokemonSource;
    public IPokemonData PlayerPokemonData => _playerPokemonSource as IPokemonData;

    private void OnValidate()
    {
        if (PlayerPokemonData == null) return;

        if (PlayerPokemonData is not IPokemonData)
        {
            Debug.LogError($"[Adapter Error] {PlayerPokemonData.Name} n'implémente pas IPokemonData ! Glisse un SSO_PokemonData ou un SSO_Gen2ToGen1PokemonAdapter.");
            _playerPokemonSource = null;
        }
    }
}