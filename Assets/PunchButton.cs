using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchButton : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick(string Punch)
    {
        animator.SetBool("attack", true);
        animator.SetBool("Idle", false);
        StartCoroutine(WaitForEating());
    }

    IEnumerator WaitForEating()
        {
            yield return new WaitForSeconds(.8f);
            animator.SetBool("attack", false);
    }
    }

 
