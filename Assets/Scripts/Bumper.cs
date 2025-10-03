using System;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] private float bumperStrength = 5f;
    
    private void OnCollisionEnter(Collision other)
    {
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction;
        direction = b - a;
        direction = direction.normalized;
        
        other.rigidbody.AddForce((direction * bumperStrength));
    }
}
