using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {

    public float speed;
    public float x;

    public Text scoreText;

    private AudioSource audioSource;
    private int p2ScoreCount;
    private bool canMove = true;
    private bool pauseTime = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Time.timeScale = 1;
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
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
        }
    }
}
