using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float minspawntime = 40f,maxspawntime = 300f;

    private float spawntime;
    // Update is called once per frame
    void Start()
    {
        spawntime = Random.Range(minspawntime, maxspawntime);
    }
    void Update()
    {

        if (spawntime == 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            spawntime = Random.Range(minspawntime, maxspawntime);
        }
        else
            spawntime = spawntime < 0 ? 0 : spawntime - Time.deltaTime;
    }
}
