using UnityEngine;

[CreateAssetMenu(fileName = "SSO_TrainerData", menuName = "Data/SSO/SSO_TrainerData")]
public class SSO_TrainerData : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    [TextArea] public string Taunt;
    [SerializeField] private ScriptableObject _pokemonSource;
    public IPokemonData Pokemon => _pokemonSource as IPokemonData;

    private void OnValidate()
    {
        if (_pokemonSource != null && _pokemonSource is not IPokemonData)
        {
            Debug.LogError($"[Adapter Error] {_pokemonSource.name} n'implémente pas IPokemonData ! Glisse un SSO_PokemonData ou un SSO_Gen2ToGen1PokemonAdapter.");
            _pokemonSource = null;
        }
    }
}