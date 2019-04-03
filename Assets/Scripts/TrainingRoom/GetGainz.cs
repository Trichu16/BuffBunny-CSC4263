using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGainz : MonoBehaviour
{
    public GameObject textBox;
    public GameObject StatusBox;
    public AudioSource GainsSound1;
    public AudioSource GainsSound2;
    public AudioSource GainsSound3;
    public AudioSource GainsSound4;
    public int GenerateTone;

    public void ClickTheButton()
    {
        GenerateTone = Random.Range(1, 5);
        if (GlobalWorkout.WorkoutCount == 0)
        {
            StatusBox.GetComponent<Text>().text = "You haven't worked out enough!";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if(GenerateTone == 1)
            {
                GainsSound1.Play();
            }
            if(GenerateTone == 2)
            {
                GainsSound2.Play();
            }
            if(GenerateTone == 3)
            {
                GainsSound3.Play();
            }
            if(GenerateTone == 4)
            {
                GainsSound4.Play();
            }
            GlobalWorkout.WorkoutCount -= 1;
            GlobalGainz.GainzCount += 1;
        }
    }
}
