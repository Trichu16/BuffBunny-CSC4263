using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTemp : MonoBehaviour
{
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Exiting Game");
#else
        Application.Quit ();
#endif
    }
}
