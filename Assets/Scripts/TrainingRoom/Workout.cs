using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource WorkoutSound1;
    public AudioSource WorkoutSound2;
    public int GenerateTone;

    public void ClickTheButton()
    {
        GenerateTone++;
        if(GenerateTone % 2 == 0)
        {
            WorkoutSound2.Play();
        }
        else
        {
            WorkoutSound1.Play();
        }
        GlobalWorkout.WorkoutCount += 1;
    }
}
