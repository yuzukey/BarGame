using UnityEngine;
using System.Collections;

public class Ramdom : MonoBehaviour {

    //プレハブを変数に代入
    public GameObject Bar;

    void start(){
        //オブジェクトの座標
        float x = Random.Range(0.0f, 10.0f);
        float y = Random.Range(0.0f, 0.0f);
        float z = Random.Range(0.0f, 40.0f);

        //オブジェクトを生産
        Instantiate(Bar, new Vector3(x, y, z), Quaternion.identity);
    }
}
