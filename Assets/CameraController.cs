using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float SENS_HOR = 2.0f;
    public float SENS_VER = 2.0f;
    GameObject character;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseMove = new Vector2(Input.GetAxisRaw("Mouse X"),
            Input.GetAxisRaw("Mouse Y"));

        mouseMove = Vector2.Scale(mouseMove, new Vector2(SENS_HOR, SENS_VER));
        character.transform.Rotate(0, mouseMove.x, 0);
        float moveAngle = transform.rotation.eulerAngles.x - mouseMove.y;
        if (moveAngle >= 285 && moveAngle <= 360 - mouseMove.y || moveAngle <= 75 && moveAngle >= 0 - mouseMove.y) // rotation limit
            transform.Rotate(-mouseMove.y, 0, 0);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
