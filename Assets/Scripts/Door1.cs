using UnityEngine;

public class Door1 : MonoBehaviour
{
    public Announcer announcer;
    public bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
            announcer.Play("block");
        triggered = true;
    }

}
