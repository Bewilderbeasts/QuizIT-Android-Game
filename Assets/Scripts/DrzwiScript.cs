using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzwiScript : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
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
    // Update is called once per frame
    void Update()
    {
        
    }
    

    
}
