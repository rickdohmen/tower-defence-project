using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath_Component : MonoBehaviour
{
	[SerializeField] private float _startHealth;

	private float _currentHealth;
    public float CurrentHealth 
    {
        get {return _currentHealth; }
    }

    private void Awake()
    {
        _currentHealth = _startHealth;
    }

    

    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;

        HandleTakeDamage();
        if(_currentHealth <= 0)
        {
            Death();
        }
        
    }

    protected virtual void HandleTakeDamage()
    {

    }

    protected virtual void Death()
    {
        
    }
    
}
