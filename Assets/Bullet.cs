using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public Cinemachine.CinemachineCollisionImpulseSource Myimpulse;
    public GameObject myparticle;
    public GameObject enemyparticle;

    private bool noParticle;
    // Start is called before the first frame update
    void Start()
    {
        noParticle = false;
        rb.velocity = transform.up * force * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Instantiate(myparticle, transform.position, transform.rotation);
            Instantiate(enemyparticle, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Wall")
        {
            noParticle = true;
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        if (!noParticle)
        {
            Myimpulse.GenerateImpulse();
            Debug.Log("Hitted");
        }
            
        else
            Debug.Log("Left");
    }

}
