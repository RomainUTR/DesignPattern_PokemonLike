using UnityEngine;

[CreateAssetMenu(fileName = "SSO_PokemonData", menuName = "Data/SSO/SSO_PokemonData")]
public class SSO_PokemonData : ScriptableObject
{
    public string Name;
    public int Level;
    public Sprite NormalSprite, ShinySprite, PlayableSprite;
    public int BaseHP;
    public int BaseDamage;
}