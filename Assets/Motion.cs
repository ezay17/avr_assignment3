using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Motion : MonoBehaviour
{
    public float speed = 0.1f;
    

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(new Vector3(1, 0, 0) * speed);
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(new Vector3(0, 1, 0) * speed);
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(new Vector3(0, -1, 0) * speed);
        }
    }
}
