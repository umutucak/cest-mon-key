using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Ray ray;
    Camera camera;
    public GameObject fuckingMonkey;
    public GreetingSpeech greetingSpeech;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {   
        RaycastHit hit;
        ray = camera.ScreenPointToRay(Input.mousePosition);
        // if press E
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, 5))
            {
                if (hit.collider.name == "GreetingMonkey")
                {
                    greetingSpeech.ContinueDialogue();
                }
            }
            return;
        }

        // always passive raycasting
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "GreetingMonkey" && hit.distance < 5)
            {
                fuckingMonkey = hit.transform.Find("InteractionText").gameObject;
                // Debug.Log(true, fuckingMonkey);
                fuckingMonkey.SetActive(true);
            }
            else
            {
                // Debug.Log(fuckingMonkey);
                fuckingMonkey.SetActive(false);
            }
        }
    }
}
