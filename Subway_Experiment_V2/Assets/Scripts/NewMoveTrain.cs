using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoveTrain : MonoBehaviour
{
    public float speed = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
