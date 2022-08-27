using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //メインカメラのオブジェクト
    private GameObject myCamera;

    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        this.myCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //画面外のアイテムを消す
        if(this.transform.position.z < this.myCamera.transform.position.z)
            {
            Destroy(this.gameObject);
            }
    }
}
