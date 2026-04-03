using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class SateliteMovment : MonoBehaviour
{
    public int HorizontalSpeed = 6;

    public AudioSource s;
    public AudioClip c;
    public delegate void playerDied();
    public static  event playerDied playerinfo;
    

    public GameObject go;                  // bullet prefab
    public BulletMovment sc;         // script on bullet (drag in inspector)
    public Text score; // UI Text
    int Score1 = 0;
    Rigidbody2D rb;
    void Awake()
    {
        BulletMovment.score = 0;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(HorizontalSpeed * x, 5 * y);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = Instantiate(go);

            bullet.transform.position = new Vector3(
                transform.position.x,
                transform.position.y + 1,
                transform.position.z
            );

            s.clip = c;
            s.Play();

            // update score text
            Score1 = BulletMovment.score;
            score.text = Score1.ToString() + " Points";


            StartCoroutine(DestroyBullet(bullet));
        }
    }

    IEnumerator DestroyBullet(GameObject bullet)
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(bullet);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Score1 = 0;
            Debug.Log("CHUD GYA :-");
            Destroy(gameObject);
            Debug.Log("EVENT ABOUT TO FIRE");
            SateliteMovment.playerinfo?.Invoke();
            //Score1 = 0;
            score.text = Score1.ToString() + "Points ";
            //Destroy(gameObject);
        }
    }
}
