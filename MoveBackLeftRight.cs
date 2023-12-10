using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public GameObject RefCamera;
    public GameObject food;


    bool foodCarry = false;

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
        transform.Translate(movement * 5f * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey("d"))
        {
            horizontalInput = 1f;
        }

        Vector3 rotation = new Vector3(0, horizontalInput, 0);
        transform.Rotate(rotation * 45f * Time.deltaTime);



        if (Input.GetKey("t"))
        {
            float moveBack = transform.position.z;
            float leftRight = transform.position.x;
            RefCamera.transform.position = new Vector3(leftRight, 15f, moveBack);
            RefCamera.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
        else
        {
            float moveCamer = transform.position.z - 10f;
            RefCamera.transform.position = new Vector3(0, 5f, moveCamer);
            RefCamera.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (foodCarry)
        {
            caryFood();
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "food")
        {
            caryFood();
            foodCarry = true;
        }
    }

    void caryFood()
    {
        food.transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
    }
}
