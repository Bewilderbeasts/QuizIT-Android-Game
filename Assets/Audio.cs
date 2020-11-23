using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    bool isMute;
    public GameObject MusicOff;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }

    public void Gone()
    {
        MusicOff.SetActive(false);
    }
}
