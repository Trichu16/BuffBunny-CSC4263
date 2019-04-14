using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWorkout : MonoBehaviour
{
    public static int WorkoutCount;
    public GameObject WorkoutDisplay;
    public int InternalWorkout;

    // Update is called once per frame
    void Update()
    {
        InternalWorkout = WorkoutCount;
        WorkoutDisplay.GetComponent<Text>().text = "Workout: "+InternalWorkout;
    }
}
