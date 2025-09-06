using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovementScript : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x * speed * Time.deltaTime, transform.position.y * speed * Time.deltaTime, transform.position.z * speed * Time.deltaTime);        
    }
}
