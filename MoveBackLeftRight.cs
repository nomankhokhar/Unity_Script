using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 45f;

    public GameObject RefCamera;

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey("w"))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey("s"))
        {
            verticalInput = -1f;
        }

        Vector3 movement = new Vector3(0, 0, verticalInput);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey("d"))
        {
            horizontalInput = 1f;
        }

        Vector3 rotation = new Vector3(0, horizontalInput, 0);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);




        float moveCamer = transform.position.z - 10f;
        RefCamera.transform.position = new Vector3(0, 5f, moveCamer);

    }
}
