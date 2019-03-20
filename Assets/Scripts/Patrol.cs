﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > 1.5)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); 
    }
}
