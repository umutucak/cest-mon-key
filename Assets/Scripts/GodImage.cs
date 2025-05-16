using UnityEngine;

public class GodImage : MonoBehaviour
{
    private float timeSpawned;

    void Start()
    {
        timeSpawned = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeSpawned > 20f)
            gameObject.SetActive(false);
    }
}
