using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackandHP : MonoBehaviour
{
    //ƒvƒŒƒCƒ„[‚ÌUŒ‚{ƒAƒjƒ[ƒVƒ‡ƒ“{HP‚Â‚­‚è‚½‚¢

    public float _attackRange = 1.5f; //UŒ‚”¼Œa
    public Transform _attackPoint; //UŒ‚‚Ì’†S’n
    public LayerMask _enemyLayer; //“G‚ÌƒŒƒCƒ„[
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
        Debug.Log("UŒ‚");
        Collider[] hitenemies = 
            Physics.OverlapSphere(_attackPoint.position, _attackRange, _enemyLayer); //ˆø”‚Éw’è‚µ‚½‹…Œ`‚Ì’†‚Ì“G‚ğæ“¾

        foreach(Collider enemy in hitenemies)
        {
            EnemyAttack enemyScript = enemy.GetComponent<EnemyAttack>();
            Debug.Log("“ü‚Á‚½");
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
