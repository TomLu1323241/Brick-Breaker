using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] GameObject paddle;
    Vector2 paddleToBall;
    bool lockOnPaddle = true;
    bool launched = false;

	// Use this for initialization
	void Start () {
        paddleToBall = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        LockBallToPaddle();
        LaunchBallOnClick();
    }

    private void LaunchBallOnClick()
    {
        if (Input.GetMouseButtonDown(0) && !launched)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10f);
            lockOnPaddle = false;
            launched = true;
        }
    }

    private void LockBallToPaddle()
    {
        if (lockOnPaddle)
        {
            Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
            transform.position = paddlePos + paddleToBall;
        }
    }
}
