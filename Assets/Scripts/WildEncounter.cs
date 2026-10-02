using System;
using UnityEngine;

public class WildEncounter : IEncounter
{
    [SerializeField] private RSE_OnPokemonCapture OnPokemonCapture;
    [SerializeField] private RSE_OnShinyFound OnShinyFound;
    
    public int EnemyHp { get; set; }
    public string EnemyName { get; private set; }
    public Sprite EnemySprite { get; private set; } 
    
    public int PlayerHp { get; set; }
    public string PlayerName { get; private set; }
    public Sprite PlayerSprite { get; private set; }

    public event Action OnEncounterEnded;
    
    private SSO_PokemonData _wildData;
    private SSO_PokemonData _playerData;
    
    public WildEncounter(SSO_PokemonData wildData, bool isShiny, SSO_PokemonData playerData)
    {
        _wildData = wildData;
        _playerData = playerData;
        
        EnemyHp = wildData.BaseHP;
        EnemyName = wildData.Name;
        EnemySprite = isShiny ? wildData.ShinySprite : wildData.NormalSprite;

        PlayerHp = playerData.BaseHP;
        PlayerName = playerData.Name;
        PlayerSprite = playerData.PlayableSprite;

        if (isShiny)
        {
            OnShinyFound?.Raise();
        }
    }

    public void Attack()
    {
        EnemyHp -= _playerData.BaseDamage;
        Debug.Log($"Tu attaques le Pokémon sauvage ! Il lui reste {EnemyHp} HP !");
        
        if (EnemyHp <= 0)
        {
            Debug.Log("Le Pokémon adverse est K.O. ! Tu as gagné !");
            EndEncounter();
        }
        else
        {
            EnemyAttack(); 
        }
    }

    public void Heal()
    {
        Debug.Log("Tu utilises une potion et récupères tes PV !");
    }

    public void EnemyAttack()
    {
        Debug.Log($"Le Pokémon sauvage t'attaque et te fais {_wildData.BaseDamage} dégâts");
    }

    public void EndEncounter()
    {
        Debug.Log("Fin du combat avec le Pokémon sauvage.");
        OnEncounterEnded?.Invoke();
    }

    public void Capture()
    {
        Debug.Log($"Tu lances une Pokéball... {_wildData.Name} est capturé !");
        OnPokemonCapture?.Raise(_wildData);
        EndEncounter();
    }

    public void Flee()
    {
        Debug.Log("Tu prends la fuite !"); 
        EndEncounter();
    }
}
