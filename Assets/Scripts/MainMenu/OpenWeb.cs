using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWeb : MonoBehaviour
{
    public string webpageURL;

    public void OpenWebpage()
    {
        Application.OpenURL(webpageURL);
    }
}
