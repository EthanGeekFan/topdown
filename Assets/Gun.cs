using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public float loadtime;
    private float loading;
    // Update is called once per frame
    void Update()
    {
        Vector3 display = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dirc = Input.mousePosition - display;
        dirc.z = 0f;
        dirc = dirc.normalized;

        transform.up = dirc;

        Fire();
    }

    void Fire()
    {
        if (Input.GetMouseButton(0) && loading == 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            loading = loadtime;
        }
        else
            loading = loading < 0 ? 0 : loading - Time.deltaTime;
    }
}
