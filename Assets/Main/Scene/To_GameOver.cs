using UnityEngine;
using System.Collections;

public class To_GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Miss"))
        {
            Application.LoadLevel(0);
        }
    }
}
