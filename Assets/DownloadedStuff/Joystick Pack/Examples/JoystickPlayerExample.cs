using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public CharacterController controller;
    public Animator animator;

    public void Update()
    {
        double H = variableJoystick.Horizontal;

        if (H < 0)
        {
            animator.SetBool("walkingleft", true);

        }
        else if (H > 0)
        {
            animator.SetBool("walkingright", true);
        }
        else
        {
            animator.SetBool("Idle", true);
        }
    }
    public void FixedUpdate()
    {
        Vector2 direction = Vector2.up * variableJoystick.Vertical + Vector2.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        
    }
}