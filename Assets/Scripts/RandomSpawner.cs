using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] fallingPrefabs;
    public float spawnInterval = 1.5f;

    private float timer = 0f;
    private float minX, maxX;

    void Start()
    {
        Camera cam = Camera.main;
        minX = cam.ViewportToWorldPoint(new Vector3(0.1f, 0, 0)).x;
        maxX = cam.ViewportToWorldPoint(new Vector3(0.9f, 0, 0)).x;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            Spawn();
        }
    }

    void Spawn()
    {
        if (fallingPrefabs.Length == 0) return;
        int idx = Random.Range(0, fallingPrefabs.Length);
        float x = Random.Range(minX, maxX);
        Instantiate(fallingPrefabs[idx], new Vector3(x, 6f, 0), Quaternion.identity);
    }
}