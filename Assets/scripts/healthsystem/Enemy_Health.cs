using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : Heath_Component
{
    public EnemyInRangeChecker rangeChecker;
   

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

    public override void TakeDamage(float amount)
    {
        base.TakeDamage(amount);
    }
}
