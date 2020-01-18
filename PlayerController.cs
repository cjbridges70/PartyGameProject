using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    GameObject player;
    float horizontal;
    float vertical;
    public Text gameOverText;
    public Text winText;
    public Text LateText;
    public GameObject playerExplosion;
    public GameObject Timer;
    public AudioClip ExplosionAudio;
    new AudioSource audio;
    public AudioClip Win;
    public AudioClip Jump;
    public AudioClip menuSound51;
    private AudioScript AS;

    private float timer = 0.0f;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        body = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Froggo");
        gameOverText.text = "";
        winText.text = "";
        LateText.text = "";
       
    }

    void Update()
    {
     

        if (transform.position.y >= 45)
        {
            winText.text = "SAFE!!";
            AudioSource.PlayClipAtPoint(Win, transform.position, 100);
            gameObject.SetActive(false);
            Timer.SetActive(false);
        }
        if (transform.position.x > 8)
        {
            gameOverText.text = "Squashed";

            AudioSource.PlayClipAtPoint(menuSound51, transform.position,400);

            Instantiate(playerExplosion, transform.position, transform.rotation);

            gameObject.SetActive(false);

        }

            if (transform.position.x < 8)
        {
            gameOverText.text = "Squashed";

            Instantiate(playerExplosion, transform.position, transform.rotation);

            AS.Explode();

            Destroy(gameObject);
        }
        timer += Time.deltaTime;
        if (timer > 12)
        {
            if (transform.position.y < 45)
            {
                
                LateText.text = "OUT OF TIME!";
                AudioSource.PlayClipAtPoint(menuSound51, transform.position, 100);

                Instantiate(playerExplosion, transform.position, transform.rotation);

                gameObject.SetActive(false);
            }
        }

    }

    void FixedUpdate()
    {
        if (transform.position.y <= 45)
        {
            if (Input.GetKeyDown("space"))
            {
                transform.position = body.position + new Vector2(0, 3.3f);
                AudioSource.PlayClipAtPoint(Jump, transform.position, 100);
            }

        }
        if (transform.position.y > 45)
        {
            if (transform.position.y < 47)
                

            if (transform.position.y > 45)
            {
                if (transform.position.y < 47)
                    transform.position = body.position + new Vector2(0, 3.3f);
            }
        }
    }
    public void Kill()
    {
        Destroy(gameObject);
    }
       

}
