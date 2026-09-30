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

    public void Attack()
    {
        PkmnHp -= 10; // Valeur arbitraire
        Debug.Log($"Tu attaques le Pokémon sauvage ! Il lui reste {PkmnHp} HP !");
    }

    public void Heal()
    {
        Debug.Log("Tu utilises une potion et récupères tes PV !");
    }

    public void EnemyAttack()
    {
        Debug.Log($"Le Pokémon sauvage t'attaque et te fais {pokemonData.BaseDamage} dégâts");
    }

    public void EndEncounter()
    {
        Debug.Log("Fin du combat avec le Pokémon sauvage.");
    }

    public void Capture()
    {
        Debug.Log($"Tu lances une Pokéball... {pokemonData.Name} est capturé !");
        EndEncounter();
    }

    public void Flee()
    {
        Debug.Log("Tu prends la fuite !"); 
        EndEncounter();
    }
}
