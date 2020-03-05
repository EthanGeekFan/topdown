using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 dirc = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dirc.z = 0f;
        transform.position = dirc;
    }
}
