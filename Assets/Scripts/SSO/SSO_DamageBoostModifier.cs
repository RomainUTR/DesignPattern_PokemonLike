using UnityEngine;

[CreateAssetMenu(fileName = "SSO_DamageBoostModifier", menuName = "Data/SSO/SSO_DamageBoostModifier")]
public class SSO_DamageBoostModifier : SSO_PokemonModifier
{
    [SerializeField, Range(1.5f, 3f)] private float DamageMultiplier = 1.5f;

    public override IPokemonData Decorate(IPokemonData pokemonToWrap)
    {
        throw new System.NotImplementedException();
    }

    public class DamageBoostDecorator : PokemonDecorator
    {
        private readonly float _multiplier;

        public DamageBoostDecorator(IPokemonData pokemon, float multiplier) : base(pokemon)
        {
            _multiplier = multiplier;
        }

        public override int BaseDamage => Mathf.RoundToInt(_wrappedPokemon.BaseDamage * _multiplier);
    }
}