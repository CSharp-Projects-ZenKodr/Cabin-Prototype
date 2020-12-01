using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator doorAnim;
    bool doorOpen;

    // Use this for initialization
    void Start()
    {
        doorOpen = false;
        doorAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (doorOpen == false) // open Door
            {
                doorOpen = true;
                doorAnim.SetTrigger("Open");
            }
            else if (doorOpen == true) // open Door
            {
                doorOpen = false;
                doorAnim.SetTrigger("Close");
            }
        }
    }
}
