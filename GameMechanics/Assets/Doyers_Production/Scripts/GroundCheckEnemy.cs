using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckEnemy : MonoBehaviour {



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NonInteractible")
        {
            Debug.Log("ik ben over de rand");
        }

        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("ik raak de grond aan");
        }
    }
}
