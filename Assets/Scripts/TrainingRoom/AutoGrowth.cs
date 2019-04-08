using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGrowth : MonoBehaviour
{
    public GameObject StatusText;
    public bool Growth = false;
    public static int GainzIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        GainzIncrease = GlobalGrowth.GrowthPerSec;
        InternalIncrease = GainzIncrease;
        if(Growth == false)
        {
            Growth = true;
            StartCoroutine(Grow());
        }
    }
    IEnumerator Grow()
    {
       
            GlobalGainz.GainzCount += InternalIncrease;
            GlobalWorkout.WorkoutCount -= 1;
            yield return new WaitForSeconds(2);
        Growth = false;

    }

    }

