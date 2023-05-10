using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopController : MonoBehaviour
{
    Rigidbody2D rb;
    public float ziplamaKuvveti = 3f;
    bool basildimi = false;
    public string mevcutRenk;
    public Color topunRengi;
    public Color turkuaz, sari, pembe, mor;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        RastGeleRenk();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
    }

    void RastGeleRenk()
    {
        int RasgeleSayi = Random.Range(0, 4);//0,1,2,3

        switch (RasgeleSayi)
        {
            case 0:
                mevcutRenk = "turkuaz";
                topunRengi = turkuaz;
                break;

            case 1:
                mevcutRenk = "Sari";
                topunRengi = sari;
                break;

            case 2:
                mevcutRenk = "Pembe";
                topunRengi = pembe;
                break;
            case 3:
                mevcutRenk = "Mor";
                topunRengi = mor;
                break;
        }
        GetComponent<SpriteRenderer>().color = topunRengi;
    }


















}//class
