using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BulletMovment : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    public static int score = 0;
    public AudioSource s;
    public AudioClip c;
    //public Text score1;
    // void Awake()
    // {
    //     //score = 0;
    // }
    void OnEnable()
    {
        //SateliteMovment.playerinfo += change;
    }
    void OnDisable()
    {
        //SateliteMovment.playerinfo -= change;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided :- Enemy");
            s.clip = c;
            s.Play();
            Destroy(collision.gameObject);
            score = score + 1;
            //score1.text = score.ToString() + "points";
        }
    }
    // void change()
    // {
    //     score = 0;
    // }
}  