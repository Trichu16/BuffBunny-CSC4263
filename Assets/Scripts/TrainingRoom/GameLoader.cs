using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int SavedWorkout;
    public int SavedGainz;
    public int SavedAutoWorkout;
    public int SavedGrowth;
    public int SavedValue;
    public int SavedGrowthLevel;
    public int SavedWorkoutLevel;

    void Start()
    {
        if(MainMenuOptions.isLoading == true)
        {
            SavedWorkout = PlayerPrefs.GetInt("Saved Workout");
            GlobalWorkout.WorkoutCount = SavedWorkout;
            SavedGainz = PlayerPrefs.GetInt("Saved Gainz");
            GlobalGainz.GainzCount = SavedGainz;
            SavedAutoWorkout = PlayerPrefs.GetInt("Saved AutoWorkout");
            GlobalAutoWorkout.WorkoutPerSec = SavedAutoWorkout;
            SavedGrowth = PlayerPrefs.GetInt("Saved Growth");
            GlobalGrowth.GrowthPerSec = SavedGrowth;
            SavedValue = PlayerPrefs.GetInt("Saved Value");
            SaveGame.saveValue = SavedValue;
            SavedGrowthLevel = PlayerPrefs.GetInt("Saved Growth Level");
            GlobalGrowth.numberOfLevel = SavedGrowthLevel;
            SavedWorkoutLevel = PlayerPrefs.GetInt("Saved Workout Level");
            GlobalAutoWorkout.NumberOfLevel = SavedWorkoutLevel;


        }
    }

}
