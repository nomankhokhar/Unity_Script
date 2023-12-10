using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstMoveMent : MonoBehaviour
{
    public GameObject PLayer;
    public GameObject RefCamera;
    public float speed = 10f;


    void Update()
    {
        float translet = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        PLayer.transform.Translate(0, 0, translet);
        if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical") == -1)
        {
            float rotate = Input.GetAxis("Horizontal") * speed * 8 * Time.deltaTime;
            PLayer.transform.Rotate(0, rotate, 0);
        }
        float moveCamer = PLayer.transform.position.z - 25;
        RefCamera.transform.position = new Vector3(0, 17f, moveCamer);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameOver")
        {
            Debug.Log("Game Over");
        }

        if (collision.gameObject.tag == "Win")
        {
            Debug.Log("Winner is Noman Ali");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            Debug.Log("You Win Again");
        }
    }
}
