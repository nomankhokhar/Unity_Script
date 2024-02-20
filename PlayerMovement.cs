using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public TextMeshProUGUI Winner;

    private float timer = 20f; 
    private bool gameIsRunning = true;

    void Update()
    {
        if (gameIsRunning)
        {
            Winner.text = "Game Starting";
            UpdateMovement();
            UpdateTimer();
        }
    }

    void UpdateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movement * 5f * Time.deltaTime);
    }

    void UpdateTimer()
    {
        timer -= Time.deltaTime;
        myText.text = timer.ToString();
        if (timer <= 0f)
        {
            StopGame();
        }
    }

    void StopGame()
    {
        gameIsRunning = false;
        Winner.text = "Game is Over";
        Debug.Log("Game Over!");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (gameIsRunning)
        {
            if (collision.gameObject.CompareTag("winWall"))
            {
                Winner.text = "Yor are the Winner";
            }
          
        }
    }
}
