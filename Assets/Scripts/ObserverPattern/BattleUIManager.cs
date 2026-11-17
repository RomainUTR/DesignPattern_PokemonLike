using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUIManager : MonoBehaviour
{
    //[Header(""Settings"")]
    [Header("References")] 
    [SerializeField] private GameObject BattleUIPanel;

    [SerializeField] private Image EnemyPokemonSprite;
    [SerializeField] private TMP_Text EnemyPokemonName;
    [SerializeField] private Image TrainerSprite;
    [SerializeField] private Image PlayerSprite;
    
    [Header("Buttons")]
    [SerializeField] private Button AttackButton;
    [SerializeField] private Button HealButton;
    
    [Header("Specific Buttons")]
    [SerializeField] private Button CaptureButton;
    [SerializeField] private Button FleeButton;
    
    [Header("Input")]
    [SerializeField] private RSE_OnEncounterTriggered OnEncounterTriggered;
    
    //[Header(""Output"")]
    
    private IEncounter _activeEncounter;

    private void OnEnable()
    {
        if (OnEncounterTriggered != null)
        {
            OnEncounterTriggered.OnEventRaised += SetupFight;
        }
    }

    private void OnDisable()
    {
        if (OnEncounterTriggered != null)
        {
            OnEncounterTriggered.OnEventRaised -= SetupFight;
        }
    }
    
    private void SetupFight(IEncounter encounter)
    {
        _activeEncounter = encounter;
        BattleUIPanel.SetActive(true);
        
        PlayerSprite.sprite = _activeEncounter.PlayerSprite;
        
        AttackButton.onClick.RemoveAllListeners();
        HealButton.onClick.RemoveAllListeners();
        CaptureButton.onClick.RemoveAllListeners();
        FleeButton.onClick.RemoveAllListeners();
        
        AttackButton.onClick.AddListener(() => _activeEncounter.Attack());
        HealButton.onClick.AddListener(() => _activeEncounter.Heal());
        
        if (_activeEncounter is WildEncounter wildEncounter)
        {
            TrainerSprite.gameObject.SetActive(false);
            EnemyPokemonSprite.sprite = _activeEncounter.EnemySprite;
            EnemyPokemonName.text = _activeEncounter.EnemyName;
            
            CaptureButton.onClick.AddListener(() => wildEncounter.Capture());
            FleeButton.onClick.AddListener(() => wildEncounter.Flee());
        } else if (_activeEncounter is TrainerEncounter trainerEncounter)
        {
            TrainerSprite.gameObject.SetActive(true);
            TrainerSprite.sprite = trainerEncounter.TrainerSprite;
            EnemyPokemonSprite.sprite = _activeEncounter.EnemySprite;
            EnemyPokemonName.text = _activeEncounter.EnemyName;
        }

        _activeEncounter.OnEncounterEnded += CloseBattleUI;
    }

    private void CloseBattleUI()
    {
        BattleUIPanel.SetActive(false);
        Time.timeScale = 1;

        if (_activeEncounter != null)
        {
            _activeEncounter.OnEncounterEnded -= CloseBattleUI;
            _activeEncounter = null;
        }
    }
}