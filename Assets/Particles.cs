using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    private ParticleSystem myparticle;

    void Start()
    {
        myparticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myparticle.isStopped)
        {
            Destroy(gameObject);
        }
    }
}
