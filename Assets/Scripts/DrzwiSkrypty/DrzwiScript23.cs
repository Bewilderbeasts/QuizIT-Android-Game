using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzwiScript23 : MonoBehaviour
{
    private Animator anim;
    private int currentRound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        currentRound = PlayerPrefs.GetInt("currentRound");
        if (other.tag == "Player" && currentRound >= 22)
        {
            anim.SetBool("DrzwiOpen", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("DrzwiOpen", false);
        }
    }
}
