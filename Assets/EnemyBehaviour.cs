using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private GameObject player;
    public Vector3 dbug;
    public float speed = 10f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        dbug = player.transform.position;

        //rotation
        Vector3 dirc = player.transform.position - transform.position;
        dirc.z = 0f;
        dirc = dirc.normalized;

        transform.up = dirc;

        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
