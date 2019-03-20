using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGainz : MonoBehaviour
{
    public GameObject textBox;
    public void ClickTheButton()
    {
        GlobalWorkout.WorkoutCount -= 1;
        GlobalGainz.GainzCount += 1;
    }
}
