using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}