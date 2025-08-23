using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 3;

    // Use this if the code below doesnt work:
    // transform.Translate(transform.forward * speed * time.deltaTime, Space.World);

    // Update is called once per frame
    private void Update()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        movementDirection = Vector3.ClampMagnitude(movementDirection, 1);

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
