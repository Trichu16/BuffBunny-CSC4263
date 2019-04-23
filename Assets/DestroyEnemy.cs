using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //if(col.gameObject.name == "wolfMinion")
        //{
        //    Destroy(col.gameObject);
        //}

        //if (col.gameObject.name == "wolfBoss")
        //{
        //    Destroy(col.gameObject);
        //}

        if (col.gameObject.name == "badgerMinion")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "badgerBoss")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "humanBoss")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "humanMinion")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "bearBoss")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "bearMinion")
        {
            Destroy(col.gameObject);
        }
    }
}
