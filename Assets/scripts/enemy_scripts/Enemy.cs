using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_Health))]
public class Enemy : MonoBehaviour
{
    private Heath_Component _healthComponent;

    private void start()
    {
        _healthComponent = GetComponent<Heath_Component>();
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    public Heath_Component GetHeath_Component()
    {
        return _healthComponent;
    }
    
        
    
}
