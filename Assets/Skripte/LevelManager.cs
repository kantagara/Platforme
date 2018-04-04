using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckpoint;
    private PlayerControllerTry igrac;




	// Use this for initialization
	void Start ()
	{
	    igrac = FindObjectOfType<PlayerControllerTry>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {

        Debug.Log ("Igrac se respawnuje");
        igrac.transform.position = currentCheckpoint.transform.position;
    }
}
