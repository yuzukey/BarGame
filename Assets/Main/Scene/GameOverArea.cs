using UnityEngine;
using System.Collections;

public class GameOverArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(0, 0.001f, 0); 
	}
}
