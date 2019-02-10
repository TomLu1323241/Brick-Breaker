using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] Sprite[] blockPhase;
    private int health = 0;
    [SerializeField] AudioClip blockHit;
    [SerializeField] AudioClip blockDestory;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        health++;
        if (health == 3)
        {
            GetComponent<AudioSource>().PlayOneShot(blockDestory);
            GameObject.Destroy(gameObject);
            return;
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(blockHit);
        }
        GetComponent<SpriteRenderer>().sprite = blockPhase[health];
    }
}
