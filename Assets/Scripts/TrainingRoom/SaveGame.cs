using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameGainz;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;

    // Update is called once per frame
    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: " + saveValue;
        saveGameGainz = GlobalGainz.GainzCount;
        if (saveGameGainz >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }
    public void SaveTheGame()
    {
        GlobalGainz.GainzCount -= saveValue;
        PlayerPrefs.SetInt("Saved Workout", GlobalWorkout.WorkoutCount);
        PlayerPrefs.SetInt("Saved Gainz", GlobalGainz.GainzCount);
        PlayerPrefs.SetInt("Saved AutoWorkout", GlobalAutoWorkout.WorkoutPerSec);
        PlayerPrefs.SetInt("Saved Growth", GlobalGrowth.GrowthPerSec);
        PlayerPrefs.SetInt("Saved Growth Level", GlobalGrowth.numberOfLevel);
        saveValue *= 2;
        PlayerPrefs.SetInt("Saved Value", saveValue);
        PlayerPrefs.SetInt("Saved Workout Level",GlobalAutoWorkout.NumberOfLevel);

    }
}
