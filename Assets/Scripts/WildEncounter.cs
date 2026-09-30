using UnityEngine;

public class WildEncounter : IEncounter
{
    public int PkmnHp { get; set; }
    private SSO_PokemonData pokemonData;
    private bool isShiny;

    public WildEncounter(SSO_PokemonData data, bool shinyFlag)
    {
        pokemonData = data;
        PkmnHp = pokemonData.BaseHP;
        isShiny = shinyFlag;
        
        Sprite spriteToUse = isShiny ? pokemonData.ShinySprite : pokemonData.NormalSprite;
        
        if (isShiny)
        {
            Debug.Log($"✨ INCROYABLE ! Un {pokemonData.Name} SHINY sauvage apparaît avec {PkmnHp} HP ! ✨");
        }
        else
        {
            Debug.Log($"Un {pokemonData.Name} sauvage apparaît avec {PkmnHp} HP !");
        }
    }

    public void Attack() {}
    public void Heal() {}
    public void EnemyAttack() {}
    public void EndEncounter() {}
    
    public void Capture() {}
    public void Flee() {}
}
