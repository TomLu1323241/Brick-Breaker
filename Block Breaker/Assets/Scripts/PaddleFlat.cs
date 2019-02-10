using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleFlat : MonoBehaviour
{

    [SerializeField] AudioClip paddleHit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0f + 256f / 200f, 16f - 256f / 200f), transform.position.y);
        transform.position = paddlePos;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(paddleHit);
        float posBall = collision.gameObject.transform.position.x;
        float posPaddle = transform.position.x;
        float paddleSize = 256f / 100f;
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(((posBall - posPaddle) / paddleSize) * 20f, 10f);
    }
}
