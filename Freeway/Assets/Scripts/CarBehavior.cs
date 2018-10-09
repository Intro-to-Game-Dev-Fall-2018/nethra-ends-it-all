using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehavior : MonoBehaviour {

    public float speed;
    public float y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Time.deltaTime, 0, 0);
	}

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Breaker")
        {
           transform.position = new Vector2(-9.452f, y);
        }
        if (collisionInfo.gameObject.tag == "Breaker2")
        {
            transform.position = new Vector3(9.442999f, y);
        }
    }
}
