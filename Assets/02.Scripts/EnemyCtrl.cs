using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    private Transform enemyTr;
    private Transform tigerTr;
    private Animator anim;

    private int hashAttackType = Animator.StringToHash("AttackType");
    private int hashAttack     = Animator.StringToHash("Attack");

    // Start is called before the first frame update
    void Start()
    {
        enemyTr = GetComponent<Transform>();
        tigerTr = GameObject.FindGameObjectWithTag("TIGER").GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    bool isAttaking = false;

    // Update is called once per frame
    void Update()
    {
        if ( !isAttaking && (enemyTr.position - tigerTr.position).sqrMagnitude <= 1.5f * 1.5f)
        {
            isAttaking = true;
            int type = Random.Range(0, 3); //0, 1, 2
            anim.SetFloat(hashAttackType, type);
            anim.SetTrigger(hashAttack);
            Invoke("RevertAttack", 2.0f);
        }
    }

    void RevertAttack()
    {
        isAttaking = false;
    }
}
