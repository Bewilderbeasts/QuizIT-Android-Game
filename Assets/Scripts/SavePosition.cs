using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class SavePosition : MonoBehaviour
    {
        public float x, y, z, xrot, yrot, zrot;
        // Start is called before the first frame update
        void Start()
        {
        Load();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Save()
        {
            x = transform.position.x;
            y = transform.position.y;
            z = transform.position.z;
            xrot = transform.rotation.x;
            yrot = transform.rotation.y;
            zrot = transform.rotation.z;

            PlayerPrefs.SetFloat("x", x);
            PlayerPrefs.SetFloat("y", y);
            PlayerPrefs.SetFloat("z", z);
            PlayerPrefs.SetFloat("xrot", xrot);
            PlayerPrefs.SetFloat("yrot", yrot);
            PlayerPrefs.SetFloat("zrot", zrot);

    }

        public void Load()
        {
            x = PlayerPrefs.GetFloat("x");
            y = PlayerPrefs.GetFloat("y");
            z = PlayerPrefs.GetFloat("z");
            xrot = PlayerPrefs.GetFloat("xrot");
            yrot = PlayerPrefs.GetFloat("yrot");
            zrot = PlayerPrefs.GetFloat("zrot");

        Vector3 LoadPosition = new Vector3(x, y, z);
        
            transform.position = LoadPosition;
            
        }
    }