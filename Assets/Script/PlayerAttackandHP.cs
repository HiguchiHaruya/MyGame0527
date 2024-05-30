using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackandHP : MonoBehaviour
{
    //�v���C���[�̍U���{�A�j���[�V�����{HP���肽��

    public float _attackRange = 1.5f; //�U�����a
    public Transform _attackPoint; //�U���̒��S�n
    public LayerMask _enemyLayer; //�G�̃��C���[
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
        Debug.Log("�U��");
        Collider[] hitenemies = 
            Physics.OverlapSphere(_attackPoint.position, _attackRange, _enemyLayer); //�����Ɏw�肵�����`�̒��̓G���擾

        foreach(Collider enemy in hitenemies)
        {
            EnemyAttack enemyScript = enemy.GetComponent<EnemyAttack>();
            Debug.Log("������");
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
