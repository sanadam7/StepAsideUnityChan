using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //���C���J�����̃I�u�W�F�N�g
    private GameObject myCamera;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����̃I�u�W�F�N�g���擾
        this.myCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //��ʊO�̃A�C�e��������
        if(this.transform.position.z < this.myCamera.transform.position.z)
            {
            Destroy(this.gameObject);
            }
    }
}
