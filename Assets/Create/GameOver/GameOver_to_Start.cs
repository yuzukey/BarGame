using UnityEngine;
using System.Collections;

public class GameOver_to_Start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Click()
    {
        Application.LoadLevel(3);
    }
}
