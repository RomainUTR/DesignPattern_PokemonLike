using UnityEngine;

public abstract class EncounterGenerator : MonoBehaviour
{
    [SerializeField] private RSE_OnEncounterTriggered OnEncounterTriggered;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();

            if (player != null && player.PlayerPokemonData != null)
            {
                Time.timeScale = 0f;
            
                IEncounter currentEncounter = CreateEncounter(player.PlayerPokemonData);
                OnEncounterTriggered?.Raise(currentEncounter);
            }
            else
            {
                Debug.LogWarning("The player dont have Player script or no PokemonData");
            }
        }
    }
    
    protected abstract IEncounter CreateEncounter(IPokemonData playerPokemon);
}