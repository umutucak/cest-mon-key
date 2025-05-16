using UnityEngine;

public class Boat : MonoBehaviour
{

    public BoatMonkey boatMonkey;
    
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;
    // Time when the movement started.
    private float elapsedTime = 0f;
    public float duration;
    private bool weHaveLiftOff = false;

   // Move to the target end position.
    void Update()
    {
        if (!weHaveLiftOff)
            return;

        elapsedTime += Time.deltaTime;
        float t = Mathf.Clamp01(elapsedTime / duration); // Normalize time 0 to 1
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, t);

        if (t >= 1f)
            weHaveLiftOff = false; // Stop moving when done
    }

    public void LiftOff()
    {
        weHaveLiftOff = true;
        boatMonkey.gameObject.SetActive(true);
    }
}
