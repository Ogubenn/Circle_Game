using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopController : MonoBehaviour
{
    Rigidbody2D rb;
    public float ziplamaKuvveti = 3f;
    bool basildimi = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            basildimi = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            basildimi = false;
        }
    }
    private void FixedUpdate()
    {
        if(basildimi)
        rb.velocity = Vector2.up * ziplamaKuvveti;
    }


}//class
