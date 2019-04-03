using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoWorkout;
    public AudioSource playSound;

    public void StartAutoWorkout()
    {
        playSound.Play();
        AutoWorkout.SetActive(true);
        GlobalGainz.GainzCount -= GlobalAutoWorkout.AutoValue;
        GlobalAutoWorkout.AutoValue *= 2;
        GlobalAutoWorkout.TurnOffButton = true;
        GlobalAutoWorkout.WorkoutPerSec += 1;
        GlobalAutoWorkout.NumberOfLevel += 1;
    }
}
