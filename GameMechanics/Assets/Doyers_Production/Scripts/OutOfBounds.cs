using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

    public GameObject[] checkpoints;
    private Vector3 currentCheckpoint;
    private bool newCheckpointReached;
    private int checkPointNumber;

	// Use this for initialization
	void Start () {

        if (checkpoints[0] == null)
            checkpoints[0].transform.position = new Vector3(0, 0, 0);

        currentCheckpoint = checkpoints[0].transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        ///TODO
        ///if player gets to new checkpoint EN is groter dan de vorige checkpoint, maar dat nieuwe checkpoint
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = currentCheckpoint;
        }
    }
}
