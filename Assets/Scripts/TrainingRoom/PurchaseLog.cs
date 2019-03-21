using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoWorkout;
    public void StartAutoWorkout()
    {
        AutoWorkout.SetActive(true);
    }
}
