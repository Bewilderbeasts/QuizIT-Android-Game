using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tablica : MonoBehaviour
{
    private Animator anim;
    public GameObject TablicaDisplay;
    
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }


    

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
        
            TablicaDisplay.SetActive(true);
            /* if (Input.GetKeyDown(KeyCode.E))
             {

                 SceneManager.LoadScene("GameScene");
             }*/
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            //anim.SetBool("tablica", false);
            TablicaDisplay.SetActive(false);
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
