using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tablica : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
   
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
           
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("tablica", false);
        }
    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
