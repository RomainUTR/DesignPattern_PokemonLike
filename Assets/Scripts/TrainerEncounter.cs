using UnityEngine;

public class TrainerEncounter : IEncounter
{
    public int PkmnHp { get; set; }
    private SSO_TrainerData trainerData;

    public TrainerEncounter(SSO_TrainerData data)
    {
        trainerData = data;
        PkmnHp = trainerData.Pokemon.BaseHP;
        Debug.Log($"Le dresseur {trainerData.Name} veut se battre ! Il envoie {trainerData.Pokemon.Name}.");
    }

    public void Attack() {}
    public void Heal() {}
    public void EnemyAttack() {}
    public void EndEncounter() {}

    public void Taunt()
    {
        Debug.Log(trainerData.Taunt);
    }
}
