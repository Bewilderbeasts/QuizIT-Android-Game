using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sciana1 : MonoBehaviour
{
    public GameObject ScianaDol1;
    public GameObject ScianaDol2;
    private int wynik;
    // Start is called before the first frame update
    void Start()
    {
      //
    }

    // Update is called once per frame
    void Update()
    {
        wynik = PlayerPrefs.GetInt("Score");
         if (wynik > 0)
        {

            ScianaDol1.SetActive(false);
            ScianaDol2.SetActive(false);


        }
    }
    
}
