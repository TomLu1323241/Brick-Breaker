using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 paddlePos = new Vector2(Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0f + 256f / 200f, 16f - 256f / 200f), transform.position.y);
        transform.position = paddlePos;
	}
}
