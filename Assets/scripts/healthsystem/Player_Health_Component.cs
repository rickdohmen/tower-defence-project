using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health_Component : Heath_Component
{
    [SerializeField] private Player_Health_UI _playerHealthUI;

    private void Start()
    {
        _playerHealthUI.UpdateUI(CurrentHealth);
    }
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        // update lifes
    }
    protected override void Death()
    {
        base.Death();
    }
}
