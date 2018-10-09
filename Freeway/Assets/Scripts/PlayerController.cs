using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float x;
    public float speed;

    public Text countText;
    public Text winText;

    private AudioSource audioSource;
    private int Count;
    private bool canMove = true;
    private bool pauseTime = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Time.timeScale = 1;
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Count = 0;
        winText.text = "";
        SetCountText();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            transform.position = new Vector2(x, -4.26f);
        }
        if (collisionInfo.gameObject.tag == "Breaker3")
        {
            transform.position = new Vector3(x, -4.26f);
            Count = Count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Score: " + Count.ToString();
        if (Count >= 10)
        {
            winText.text = "Player 1 Wins!";
        }
    }
}
