using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{

    private bool isReversed = false;
    private Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isReversed = !isReversed;

            if (isReversed)
            {
                // Rotate the triangle 180 degrees (or pi radians) around its up axis (Y axis).
                transform.rotation = originalRotation * Quaternion.Euler(0, 90, 0);
            }
            else
            {
                // Reset the rotation to its original state.
                transform.rotation = originalRotation;
            }
        }
    }
}
