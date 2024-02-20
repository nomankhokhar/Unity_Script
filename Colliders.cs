using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject refred;
    public GameObject refgreen;
    public GameObject refblue;

 void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.CompareTag("collidered"))
            {
                Destroy(refred);
            }
            else if (collision.gameObject.CompareTag("collidegreen"))
            {
                Destroy(refgreen);
            }
            else if (collision.gameObject.CompareTag("collideblue"))
            {
                Destroy(refblue);
            }
    }
}
