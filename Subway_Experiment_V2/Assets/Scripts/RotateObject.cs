// Interpolates rotation between the rotations "from" and "to"
// (Choose from and to not to be the same as
// the object you attach this script to)

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
