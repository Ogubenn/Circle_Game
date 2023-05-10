using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopController : MonoBehaviour
{
    Rigidbody2D rb;
    public float ziplamaKuvveti = 3f;
    bool basildimi = false;
    public string mevcutRenk;
    public Color topunRengi;
    public Color turkuaz, sari, pembe, mor;
    [SerializeField]
    Text ScoreText;
    public static int score = 0;
    public GameObject halka, renkTekeri;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ScoreText.text = "Score  " + score;
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
        if (collision.tag == "RenkTekeri")
        {
            RastGeleRenk();
            Destroy(collision.gameObject);
            return;
        }

        if((collision.tag != mevcutRenk) && (collision.tag != "PuanArttirici") && (collision.tag != "RenkTekeri"))
        {
            score = 0;//Can sistemi yapılcak.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("GG");
        }

        if(collision.tag == "PuanArttirici")
        {
            score += 5;
            ScoreText.text = "Score  " + score;
            Destroy(collision.gameObject);

            Instantiate(halka, new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z), Quaternion.identity);
            Instantiate(renkTekeri, new Vector3(transform.position.x, transform.position.y + 12f, transform.position.z), Quaternion.identity);
        }
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
