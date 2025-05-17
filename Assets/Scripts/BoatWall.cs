using UnityEngine;

public class BoatWall : MonoBehaviour
{
    public Announcer announcer;
    public BoatWallparent _parent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!_parent.triggered)
            announcer.Play("block");
        _parent.triggered = true;
    }

}
