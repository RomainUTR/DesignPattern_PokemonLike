using UnityEngine;

[CreateAssetMenu(fileName = "SSO_Gen2ToGen1PokemonAdapter", menuName = "Data/SSO/SSO_Gen2ToGen1PokemonAdapter")]
public class SSO_Gen2ToGen1PokemonAdapter : ScriptableObject, IPokemonData
{
    [SerializeField] private SSO_Gen2_PokemonData Data;

    public string Name => Data.Name;
    public int Level => Data.Level;
    public int BaseHP => Data.BaseHP;
    public Sprite NormalSprite => Data.NormalSprite;
    public Sprite ShinySprite => Data.ShinySprite;
    public Sprite PlayableSprite => Data.PlayableSprite;
    public int BaseDamage => Data.BaseDamage;

    public PokemonType PrimaryType
    {
        get
        {
            return Data.Type switch
            {
                PokemonTypeGen2.Normal => PokemonType.Normal,
                PokemonTypeGen2.Fire => PokemonType.Fire,
                PokemonTypeGen2.Water => PokemonType.Water,
                PokemonTypeGen2.Grass => PokemonType.Grass,
                PokemonTypeGen2.Electrik => PokemonType.Electrik,
                PokemonTypeGen2.Ice => PokemonType.Ice,
                PokemonTypeGen2.Fighting => PokemonType.Fighting,
                PokemonTypeGen2.Poison => PokemonType.Poison,
                PokemonTypeGen2.Ground => PokemonType.Ground,
                PokemonTypeGen2.Flying => PokemonType.Flying,
                PokemonTypeGen2.Psychic => PokemonType.Psychic,
                PokemonTypeGen2.Bug => PokemonType.Bug,
                PokemonTypeGen2.Rock => PokemonType.Rock,
                PokemonTypeGen2.Ghost => PokemonType.Ghost,
                PokemonTypeGen2.Dragon => PokemonType.Dragon,

                PokemonTypeGen2.Dark => PokemonType.Normal,
                PokemonTypeGen2.Steel => PokemonType.Normal,

                _ => PokemonType.Normal,
            };
        }
    }
}