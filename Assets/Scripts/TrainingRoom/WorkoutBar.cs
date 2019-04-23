using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkoutBar : MonoBehaviour
{
        Image WorkoutProg;
        float maxValue;
        public static float WorkoutCount;

        void Start()
        {
            WorkoutProg = GetComponent<Image>();
        }
        void Update()
        {
            maxValue = (float)GlobalGrowth.GrowthValue;
            WorkoutCount = (float)GlobalGainz.GainzCount;
            WorkoutProg.fillAmount = WorkoutCount / maxValue;
        }

    }
