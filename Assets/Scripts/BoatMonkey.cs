using UnityEngine;

public class BoatMonkey : MonoBehaviour
{
    private float duration = 1.5f;
    private bool scaling = true;
    private float elapsedTime = 0f;
    private Vector3 startScale = new Vector3(0.2f, 0.2f, 0.2f);
    private Vector3 finalScale = new Vector3(0.5f, 0.5f, 0.5f);
    public Announcer announcer;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updating");
        if (scaling)
            Scale();
            return;
    }

    public void Caught()
    {
        announcer.Play("monkey");
    }

    void Scale()
    {
        Debug.Log("scaling!");
        elapsedTime += Time.deltaTime;
        float t = Mathf.Clamp01(elapsedTime / duration); // Normalize time 0 to 1
        transform.localScale = Vector3.Lerp(startScale, finalScale, t);
        if (t >= 1f)
            scaling = false; // Stop moving when done
    }
}
