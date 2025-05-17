using UnityEngine;

public class PlanePoolWall : MonoBehaviour
{
    public Announcer announcer;
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
            announcer.Play("block");
        triggered = true;
    }

}
