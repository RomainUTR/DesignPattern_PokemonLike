using UnityEngine;

[CreateAssetMenu(fileName = "SSO_TrainerData", menuName = "Data/SSO/SSO_TrainerData")]
public class SSO_TrainerData : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    [TextArea] public string Taunt;
    public SSO_PokemonData Pokemon;
}