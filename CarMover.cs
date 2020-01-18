using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    private float nextActionTime = 1.0f;
    public float period = 0.1f;
    Rigidbody2D body;
    Vector2 place = new Vector2(-19.21f, 6.6f);


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnNext", 4f);

        var body = GetComponent<Rigidbody2D>();
        body.velocity = (transform.right) * (Random.Range(10, 5));
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;


        }
    }

    void SpawnNext()
    {

        GameObject newBox = Instantiate(gameObject);
        newBox.transform.position = place;
    }
}
