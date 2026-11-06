using UnityEngine;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Find your GameManager and trigger a lost life
            FindObjectOfType<GameManager>().PlayerDied();
        }
    }
}