using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TwoDPlayer : MonoBehaviour
{
    public float speed;
    private float Move;
public TextMeshProUGUI time;
    public float jump;
    private Rigidbody2D rb;

    private float timer = 20f;
    private bool gameIsRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if(gameIsRunning){
            UpdateMovement();
            UpdateTime();
        }
    }
    void UpdateTime(){
        timer -= Time.deltaTime;
        time.text = timer.ToString();
        if(timer <= 0){
            StopGame();
        }
    }

    void StopGame(){
        gameIsRunning = false;
    }
    void UpdateMovement(){
        
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);        

        if(Input.GetButtonDown("Jump")){
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}
