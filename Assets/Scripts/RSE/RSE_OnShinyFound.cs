using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "RSE_OnShinyFound", menuName = "Events/RSE_OnShinyFound")]
public class RSE_OnShinyFound : ScriptableObject
{
    public event UnityAction OnEventRaised;

    public void Raise()
    {
        OnEventRaised?.Invoke();
    }
}