using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGainz : MonoBehaviour
{
    public GameObject textBox;
    public GameObject StatusBox;
    public void ClickTheButton()
    {
        if (GlobalWorkout.WorkoutCount == 0)
        {
            StatusBox.GetComponent<Text>().text = "You haven't worked out enough!";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalWorkout.WorkoutCount -= 1;
            GlobalGainz.GainzCount += 1;
        }
    }
}
