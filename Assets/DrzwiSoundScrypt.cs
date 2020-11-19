using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzwiSoundScrypt : MonoBehaviour
{
    public AudioSource drzwiSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playSoundEffect()
    {
        drzwiSound.Play();
    }
}
