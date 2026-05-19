using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -6f)
            Destroy(gameObject);
    }
}