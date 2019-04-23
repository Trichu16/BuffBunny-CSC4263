using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainzBar : MonoBehaviour
{
        Image GainzProg;
        float maxValue;
        public static float GainzCount;

        void Start()
        {
            GainzProg = GetComponent<Image>();
        }
        void Update()
        {
            maxValue = (float)GlobalAutoWorkout.AutoValue;
            GainzCount = (float)GlobalGainz.GainzCount;
            GainzProg.fillAmount = GainzCount / maxValue;
        }

    }
