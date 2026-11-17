using UnityEngine;

public abstract class PokemonDecorator : IPokemonData
{
    protected IPokemonData _wrappedPokemon;

    protected PokemonDecorator(IPokemonData wrappedPokemon)
    {
        _wrappedPokemon = wrappedPokemon;
    }

    public virtual string Name => _wrappedPokemon.Name;
    public virtual int Level => _wrappedPokemon.Level;
    public virtual int BaseHP => _wrappedPokemon.BaseHP;
    public virtual int BaseDamage => _wrappedPokemon.BaseDamage;
    public virtual Sprite NormalSprite => _wrappedPokemon.NormalSprite;
    public virtual Sprite ShinySprite => _wrappedPokemon.ShinySprite;
    public virtual Sprite PlayableSprite => _wrappedPokemon.PlayableSprite;
    public virtual PokemonType PrimaryType => _wrappedPokemon.PrimaryType;
}
