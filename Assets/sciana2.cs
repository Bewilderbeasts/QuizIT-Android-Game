using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sciana2 : MonoBehaviour
{
    public GameObject ScianaGor1;
    public GameObject ScianaGor2;
    private int wynik;
    // Start is called before the first frame update
    void Start()
    {
        wynik = PlayerPrefs.GetInt("Poziom");
        if (wynik > 1)
        {

            ScianaGor1.SetActive(false);
            ScianaGor2.SetActive(false);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
