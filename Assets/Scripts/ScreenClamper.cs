using UnityEngine;

public class ScreenClamper : MonoBehaviour
{
    public float speed = 6f;
    private float minX, maxX;

    void Start()
    {
        Camera cam = Camera.main;
        minX = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        maxX = cam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minX + 0.5f, maxX - 0.5f);
        transform.position = pos;
    }
}