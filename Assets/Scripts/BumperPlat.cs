using UnityEngine;

public class BumperPlat : MonoBehaviour
{
    [SerializeField] float bumperStrength = 1;
    [SerializeField] bool normalVector = false;

    void OnCollisionEnter(Collision other)
    {
        Vector3 ballDirection = other.relativeVelocity;
        Vector3 normal = -other.contacts[0].normal;
        Vector3 direction = Vector3.Reflect(ballDirection, normal);

        Debug.DrawRay(other.contacts[0].point, direction, Color.red, 10);
        Debug.DrawRay(other.contacts[0].point, normal, Color.blue, 10);

        if (normalVector == false)
        {
            other.rigidbody.AddForce(direction * bumperStrength);
        }
        else
        {
            other.rigidbody.AddForce(normal * bumperStrength * 8);
        }

    }

}
