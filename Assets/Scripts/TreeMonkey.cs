using UnityEngine;

public class TreeMonkey : MonoBehaviour
{
    public Announcer announcer;
    private bool isCaught = false;

    public void Caught()
    {
        if (!isCaught)
        {
            isCaught = true;
            announcer.Play("monkey");
        }
    }
}
