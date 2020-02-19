using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SPEED = 10.0f;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        // Get input
        float mvX = Input.GetAxis("Horizontal");
        float mvZ = Input.GetAxis("Vertical");

        // Move in direction
        Vector3 moveDir = new Vector3(mvX, 0, mvZ);
        moveDir = transform.TransformDirection(moveDir);
        GetComponent<CharacterController>().Move(moveDir * Time.deltaTime * SPEED);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)) // sneak
        {

        }
    }
}
