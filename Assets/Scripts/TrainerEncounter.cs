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

    public void Attack() 
    { 
        PkmnHp -= 10; 
        Debug.Log($"Tu attaques le {trainerData.Pokemon.Name} du dresseur ! Il lui reste {PkmnHp} PV.");
    }

    public void Heal() 
    { 
        Debug.Log("Tu te soignes !"); 
    }

    public void EnemyAttack() 
    { 
        Debug.Log($"Le dresseur ordonne à {trainerData.Pokemon.Name} d'attaquer !"); 
    }

    public void EndEncounter() 
    { 
        Debug.Log($"Fin du combat contre le dresseur {trainerData.Name}.");
    }
    
    public void Taunt() 
    { 
        Debug.Log($"Tu provoques le dresseur ! Il répond : '{trainerData.Taunt}'"); 
    }
}
