using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public GameObject theDriver;
    public float xpos;
    public float ypos;
    public float zpos; 

    // Update is called once per frame
    void Update()
    {
       xpos = theDriver.transform.eulerAngles.x;
        ypos = theDriver.transform.eulerAngles.y;
        zpos = theDriver.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(xpos - xpos, ypos, zpos - zpos);
    }
}
