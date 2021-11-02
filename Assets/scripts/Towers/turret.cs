using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]
public class turret : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 5;
    [SerializeField] private float _shootCooldown = 0.5f;
    [SerializeField] private Transform _turret;

    private EnemyInRangeChecker _enemyInRangeChecker;
    private float _nextShootTime = 0;

    private void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();
    }

    private void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if(enemy != null)
        {
            _turret.LookAt(enemy.transform);
            if (CanShoot())
            {
                _nextShootTime = Time.time + _shootCooldown;
                print("ShootEmey");
            }
        }
    }

    private bool CanShoot()
    {
        return Time.time >= _nextShootTime;
    }
}
