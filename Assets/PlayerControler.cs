using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject myparticle;

    public float speed;
    public float x, y;

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(x * speed * Time.fixedDeltaTime, y * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Instantiate(myparticle, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }

    void OnDisable()
    {
        
        Debug.Log("DEAD");
    }
}
