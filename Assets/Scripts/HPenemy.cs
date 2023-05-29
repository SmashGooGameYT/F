using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPenemy : MonoBehaviour
{
    public float maxHP = 3f;
    float HP;
    [SerializeField] GameObject g1;


    void Start()
    {
        HP = maxHP;
    }




    public void TakeDamage(float damage)
    {

        HP -= damage;

        if (HP <= 0)
        {
            Destroy(g1);
        }
    }
}
