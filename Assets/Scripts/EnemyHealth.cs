using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitpoints = 5;

    [Tooltip("Adds amount to maxHitPoints when enemy dies")]
    [SerializeField] int difficultyRamp = 1;
    
    int currentHitpoints = 0;

    Enemy enemy;
    
    void OnEnable() 
    {
        currentHitpoints = maxHitpoints;   
    }

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other) 
    {
        ProcessHit();
        if(currentHitpoints <= 0)
        {
            KillEnemy();
        }
    }

    void ProcessHit()
    {
        currentHitpoints--;
    }

    void KillEnemy()
    {
        gameObject.SetActive(false);
        maxHitpoints += difficultyRamp;
        enemy.RewardGold();
    }
}
