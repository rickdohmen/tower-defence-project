using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_Health))]
public class Enemy : MonoBehaviour
{
    private Heath_Component _healthComponent;
    private Enemy_Health _Enemyhealth;

    private void Awake()
    {
        _healthComponent = GetComponent<Heath_Component>();
        _Enemyhealth = GetComponent<Enemy_Health>();
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    public Heath_Component GetHeath_Component()
    {
        return _healthComponent;
    }
    
        
    public void TakeDamage()
    {
        _Enemyhealth.TakeDamage(5);
    }
}
