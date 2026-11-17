using UnityEngine;

public enum PokemonTypeGen2
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
    Dragon,
    Dark,
    Steel
}

[CreateAssetMenu(fileName = "SSO_Gen2_PokemonData", menuName = "Data/SSO/SSO_Gen2_PokemonData")]
public class SSO_Gen2_PokemonData : ScriptableObject
{
    public string Name;
    public int Level;
    public PokemonTypeGen2 Type;
    public Sprite NormalSprite, ShinySprite, PlayableSprite;
    public int BaseHP;
    public int BaseDamage;
}