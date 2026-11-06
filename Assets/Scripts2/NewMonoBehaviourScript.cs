using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public float bounceForce = 12f;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rb))
        {
            // PDF Requirement: VelocityChange for mass-independent kick
            rb.AddForce(Vector3.up * bounceForce, ForceMode.VelocityChange);
        }
    }
}