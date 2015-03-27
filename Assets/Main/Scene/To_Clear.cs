using UnityEngine;
using System.Collections;

public class To_Clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Clear"))
        {
            Application.LoadLevel(2);
        }
    }
}
