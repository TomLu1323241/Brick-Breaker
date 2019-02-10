using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene().name.Equals("Level 2"))
        {
            Debug.Log(transform.childCount);
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
}
