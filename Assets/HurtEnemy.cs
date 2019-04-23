using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtEnemy : MonoBehaviour
{
    public int damageToGive;
    public Button Punch;
    public Animator animator;

    // Start is called before the first frame update


    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy" )
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            
                animator.SetBool("walkingright", true);
        }
        else
        {
                animator.SetBool("Idle", true);
            
        }
    }
    }

