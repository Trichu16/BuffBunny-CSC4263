using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animController : MonoBehaviour
{
    public Animator animator;
    public Button Punch;
  
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    public void OnClick(Button Punch)
    {
        animator.SetBool("attack", true);
    }
   
    }
   