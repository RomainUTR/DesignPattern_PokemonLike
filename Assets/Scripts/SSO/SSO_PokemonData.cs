using UnityEngine;

public enum PokemonType
{
    Normal,
    Fire,
    Water,
    Grass,
    Electrik,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}

[CreateAssetMenu(fileName = "SSO_PokemonData", menuName = "Data/SSO/SSO_PokemonData")]
public class SSO_PokemonData : ScriptableObject, IPokemonData
{
    [SerializeField] private string _name;
    [SerializeField] private int _level;
    [SerializeField] private PokemonType _type;
    [SerializeField] public Sprite _normalSprite, _shinySprite, _playableSprite;
    [SerializeField] private int _baseHP;
    [SerializeField] private int _baseDamage;

    public string Name => _name;
    public int Level => _level;
    public PokemonType PrimaryType => _type;
    public Sprite NormalSprite => _normalSprite;
    public Sprite ShinySprite => _shinySprite;
    public Sprite PlayableSprite => _playableSprite;

    public int BaseHP => _baseHP;
    public int BaseDamage => _baseDamage;
}