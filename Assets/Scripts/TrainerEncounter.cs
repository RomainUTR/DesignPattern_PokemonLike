using UnityEngine;
using System;

public class TrainerEncounter : IEncounter
{
    public int EnemyHp { get; set; }
    public string EnemyName { get; private set; }
    public Sprite EnemySprite { get; private set; }
    
    public int PlayerHp { get; set; }
    public string PlayerName { get; private set; }
    public Sprite PlayerSprite { get; private set; }
    
    public string TrainerName { get; private set; }
    public Sprite TrainerSprite { get; private set; }
    
    private SSO_TrainerData _trainerData;
    private SSO_PokemonData _playerData;
    
    public event Action OnEncounterEnded;
    
    public TrainerEncounter(SSO_TrainerData trainerData, SSO_PokemonData playerData)
    {
        _trainerData = trainerData;
        _playerData = playerData;
        
        EnemyHp = _trainerData.Pokemon.BaseHP;
        EnemyName = _trainerData.Pokemon.Name;
        EnemySprite = _trainerData.Pokemon.NormalSprite;
        
        PlayerHp = _playerData.BaseHP;
        PlayerName = _playerData.Name;
        PlayerSprite = _playerData.PlayableSprite;

        TrainerName = _trainerData.Name;
        TrainerSprite = _trainerData.Sprite;

        Debug.Log($"Le dresseur {TrainerName} veut se battre ! Il envoie {EnemyName}.");
    }

    public void Attack() 
    { 
        EnemyHp -= _playerData.BaseDamage;
        Debug.Log($"Ton {PlayerName} attaque ! Il reste {EnemyHp} HP au {EnemyName} adverse.");
        
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
        PlayerHp += 20; 
        Debug.Log($"Tu soignes {PlayerName}. Il a maintenant {PlayerHp} HP.");
    }

    public void EnemyAttack() 
    { 
        PlayerHp -= _trainerData.Pokemon.BaseDamage;
        Debug.Log($"Le {EnemyName} adverse attaque ! Ton {PlayerName} tombe à {PlayerHp} HP.");
    }

    public void EndEncounter() 
    { 
        Debug.Log($"Fin du combat contre le dresseur {TrainerName}.");
        OnEncounterEnded?.Invoke();
    }
    
    public void Taunt() 
    { 
        Debug.Log($"Tu provoques {TrainerName} ! Il répond : '{_trainerData.Taunt}'"); 
    }
}