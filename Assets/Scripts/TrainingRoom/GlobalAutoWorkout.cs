using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalAutoWorkout : MonoBehaviour
{
    public GameObject FakeButton;
    public GameObject FakeText;
    public GameObject RealButton;
    public GameObject RealText;
    public int CurrentGainz;
    public static int AutoValue = 10;
    public static bool TurnOffButton=false;
    public GameObject LevelStats;
    public static int NumberOfLevel;
    public static int WorkoutPerSec;



    void Update()
    {
        CurrentGainz = GlobalGainz.GainzCount;
        LevelStats.GetComponent<Text>().text = "Level: "+NumberOfLevel+" @ "+WorkoutPerSec+" per sec";
        FakeText.GetComponent<Text>().text = "Level Up: " + AutoValue;
        RealText.GetComponent<Text>().text = "Level Up: " + AutoValue;
        if (CurrentGainz >= AutoValue)
        {
            FakeButton.SetActive(false);
            RealButton.SetActive(true);
        }
        if (TurnOffButton == true)
        {
            RealButton.SetActive(false);
            FakeButton.SetActive(true);
            TurnOffButton = false;
        }
    }
}
