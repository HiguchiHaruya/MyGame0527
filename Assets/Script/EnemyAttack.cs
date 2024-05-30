using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    int _enemyHp = 20;
    int _currentHp;
    void Start()
    {
        _currentHp = _enemyHp; 
    }
    public void TakeDamage(int damage)
    {
        _currentHp -= damage;
        if( _currentHp <= 0 )Die();
        Debug.Log("当たった");
    }
    void Die()
    {
        Debug.Log("死んだ!!!!");
    }
}
