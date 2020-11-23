using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    bool isMute;
    public GameObject MusicOff;
    public GameObject AudioOn;
    public GameObject AudioOff;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
        Gone();
    }

    public void Gone()
    {
        if (isMute)
        {
            AudioOn.SetActive(false);
            AudioOff.SetActive(true);
        }
        else
        {
            AudioOn.SetActive(true);
            AudioOff.SetActive(false);
        }
        
    }
}
