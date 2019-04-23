using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;
    public Animator animator;

    void Start()
    {
        /*if enemy walks left
         * GetGetComponent<Animator>().Play("Attack");
         * if enemy walks right
         * GetComponent<Animator>().Play("walkside");
         * if enemy walks up
         * GetComponent<Animator>().Play("walkup");
         * if enemy walks down
         * GetComponent<Animator>().Play("walkdown");
         * if enemy is not moving
         * GetComponent<Animator>().Play("idle");        
         *        
         *        
         */
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            animator.SetBool("Moving", true);
        }
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance)
        {
            animator.SetBool("Attack", true);
        }
        
    }
}


