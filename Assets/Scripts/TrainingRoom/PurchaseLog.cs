using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoWorkout;
    public GameObject AutoGrowth;
    public GameObject FightButton;
    public AudioSource playSound;

    public void StartAutoWorkout()
    {
        playSound.Play();
        AutoWorkout.SetActive(true);
        GlobalGainz.GainzCount -= GlobalAutoWorkout.AutoValue;
        GlobalAutoWorkout.AutoValue *= 2;
        GlobalAutoWorkout.TurnOffButton = true;
        GlobalGrowth.TurnOffButton = true;
        GlobalAutoWorkout.WorkoutPerSec += 1;
        GlobalAutoWorkout.NumberOfLevel += 1;
        if (GlobalAutoWorkout.NumberOfLevel >2)
        {
            FightButton.SetActive(true);
        }
    }

    public void StartAutoGrowth()
    {
        playSound.Play();
        AutoGrowth.SetActive(true);
        GlobalGainz.GainzCount -= GlobalGrowth.GrowthValue;
        GlobalGrowth.GrowthValue *= 2;
        GlobalGrowth.TurnOffButton = true;
        GlobalAutoWorkout.TurnOffButton = true;
        GlobalGrowth.GrowthPerSec += 1;
        GlobalGrowth.numberOfLevel += 1;
    }
}
