﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalGrowth : MonoBehaviour
{
    public GameObject FakeButton;
    public GameObject FakeText;
    public GameObject RealButton;
    public GameObject RealText;
    public int CurrentGainz;
    public static int GrowthValue = 50;
    public static bool TurnOffButton=false;
    public GameObject LevelStats;
    public static int numberOfLevel;
    public static int GrowthPerSec;



    void Update()
    {
        CurrentGainz = GlobalGainz.GainzCount;
        LevelStats.GetComponent<Text>().text = "Growth: "+numberOfLevel+" @ "+GrowthPerSec+" per sec";
        FakeText.GetComponent<Text>().text = "Grow: " + GrowthValue;
        RealText.GetComponent<Text>().text = "Grow: " + GrowthValue;
        if (CurrentGainz >= GrowthValue)
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
