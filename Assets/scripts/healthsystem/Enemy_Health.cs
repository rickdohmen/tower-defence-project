using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : Heath_Component
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        //update the health bar

    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }

}
