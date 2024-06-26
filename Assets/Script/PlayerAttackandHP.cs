using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackandHP : MonoBehaviour
{
    //プレイヤーの攻撃＋アニメーション＋HPつくりたい

    public float _attackRange = 1.5f; //攻撃半径
    public Transform _attackPoint; //攻撃の中心地
    public LayerMask _enemyLayer; //敵のレイヤー
    private int _Hp = 100;
    public int _damage = 10;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0)) Attack();
    }
    void Attack()
    {
        Debug.Log("攻撃");
        Collider[] hitenemies = 
            Physics.OverlapSphere(_attackPoint.position, _attackRange, _enemyLayer); //引数に指定した球形の中の敵を取得

        foreach(Collider enemy in hitenemies)
        {
            EnemyAttack enemyScript = enemy.GetComponent<EnemyAttack>();
            Debug.Log("入った");
            if(enemyScript != null)
            {
                enemyScript.TakeDamage(_damage);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (_attackPoint == null)
            return;

        Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
    }

    public int HP { get { return _Hp; } private set { _Hp = value; } }
}
