using System;

public interface IEncounter
{
    int PkmnHP { get; set; }
    void Attack();
    void Heal();
    void EnemyAttack();
    void EndEncounter();
}