using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform topTrans;

    private void LateUpdate()
    {
        if(topTrans.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, topTrans.position.y, transform.position.z);
        }
    }



}//Class
