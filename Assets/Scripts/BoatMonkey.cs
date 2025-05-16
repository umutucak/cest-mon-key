using UnityEngine;

public class BoatMonkey : MonoBehaviour
{
    private float duration = 2.0f;
    private bool scaling = false;
    private float elapsedTime = 0f;
    private Vector3 startScale = new Vector3(0.2f, 0.2f, 0.2f);
    private Vector3 finalScale = new Vector3(1f, 1f, 1f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scaling)
            Scale();
            return;

        
        
    }

    void Scale()
    {
        elapsedTime += Time.deltaTime;
        float t = Mathf.Clamp01(elapsedTime / duration); // Normalize time 0 to 1
        transform.position = Vector3.Lerp(startScale, finalScale, t);
        if (t >= 1f)
            scaling = false; // Stop moving when done
    }
}
