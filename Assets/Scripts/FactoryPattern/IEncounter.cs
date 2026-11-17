using System;
using UnityEngine;

public interface IEncounter
{
    int EnemyHp { get; set; }
    string EnemyName { get; }
    Sprite EnemySprite { get; } 
    
    int PlayerHp { get; set; }
    string PlayerName { get; }
    Sprite PlayerSprite { get; }

    public event Action OnEncounterEnded;

    void Attack();
    void Heal();
    void EnemyAttack();
    void EndEncounter();
}