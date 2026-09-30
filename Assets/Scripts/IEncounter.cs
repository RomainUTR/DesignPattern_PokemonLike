using System;

public interface IEncounter
{
    int PkmnHp { get; set; }
    void Attack();
    void Heal();
    void EnemyAttack();
    void EndEncounter();
}