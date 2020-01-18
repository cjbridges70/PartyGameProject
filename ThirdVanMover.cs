using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdVanMover : MonoBehaviour
{
    public Collider2D objectCollider;
    public Collider2D anotherCollider;

    public float period = 0.1f;
    Rigidbody2D body;
    Vector2 place = new Vector2(-19.05f, 39.97f);


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnNext", 1f);

        var body = GetComponent<Rigidbody2D>();
        body.velocity = (transform.right) * (Random.Range(30, 25));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnNext()
    {

        GameObject newBox = Instantiate(gameObject);
        newBox.transform.position = place;
    }
}
