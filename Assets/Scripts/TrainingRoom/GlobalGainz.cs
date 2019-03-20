using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalGainz : MonoBehaviour
{
    public static int GainzCount;
    public GameObject GainzDisplay;
    public int InternalGainz;

    // Update is called once per frame
    void Update()
    {
        InternalGainz = GainzCount;
        GainzDisplay.GetComponent<Text>().text = "Gainz: "+InternalGainz;
    }
}
