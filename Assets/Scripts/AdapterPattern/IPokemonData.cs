using UnityEngine;

public interface IPokemonData
{
    string Name { get; }
    int Level { get; }
    PokemonType PrimaryType { get; }
    Sprite NormalSprite { get; }
    Sprite ShinySprite { get; }
    Sprite PlayableSprite { get; }
    int BaseHP { get; }
    int BaseDamage { get; }
}
