using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            camera1();
        }
        if (Input.GetKeyDown("2"))
        {
            camera2();
        }
        if(Input.GetKeyDown("3"))
        {
            camera3();
        }
    }
    void camera1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
    }
    void camera3()
    {
        cam2.SetActive(false);  
        cam3.SetActive(true);
        cam1.SetActive(false);
    }
    void camera2()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
    }
}
