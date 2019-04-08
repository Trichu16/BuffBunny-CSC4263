using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGrowth : MonoBehaviour
{

    public bool CreatingWorkout = false;
    public static int WorkoutIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        WorkoutIncrease = GlobalAutoWorkout.WorkoutPerSec;
        InternalIncrease = WorkoutIncrease;
        if(CreatingWorkout == false)
        {
            CreatingWorkout = true;
            StartCoroutine(CreateTheWorkout());
        }
    }
    IEnumerator CreateTheWorkout()
    {
        GlobalWorkout.WorkoutCount += InternalIncrease;
        yield return new WaitForSeconds(2);
        CreatingWorkout = false;
    }
}
