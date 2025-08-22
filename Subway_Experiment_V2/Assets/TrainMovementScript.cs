using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovementScript : MonoBehaviour
{
    public float speed = 3;
    public Vector3 target = new Vector3(0,0,2);

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);        
    }
}
