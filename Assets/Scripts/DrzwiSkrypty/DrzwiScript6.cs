using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzwiScript6 : MonoBehaviour
{
    private bool showText = false;
    private int currentRoom;
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
        if (other.tag == "Player" && currentRound >= 5)
        {
            anim.SetBool("DrzwiOpen", true);
        }
        else
        {
            showText = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            showText = false;
            anim.SetBool("DrzwiOpen", false);
        }
    }
    void OnGUI()
    {
        currentRoom = currentRound + 1;
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        centeredStyle.fontSize = 30;
        if (showText)
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 250, 125), "Nie masz dostępu. Idź do sali:" + currentRoom.ToString(), centeredStyle);
    }
}
