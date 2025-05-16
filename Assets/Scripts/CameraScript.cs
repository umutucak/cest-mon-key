using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Ray ray;
    Camera camera;
    public GameObject fuckingMonkey;
    public GreetingSpeech greetingSpeech;
    public LightHouseMonkey lighthouseMonkey;
    public GameObject hand;
    public Boat boat;

    private float leftClickTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {   
        HandTimer();
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
                else if (hit.collider.name == "WoodBoat")
                {
                    boat.LiftOff();
                }
            }
            return;
        }
        // if left click
        if (Input.GetMouseButtonDown(0))
        {
            leftClickTimer = Time.time;
            hand.SetActive(true);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "LightHouseMonkey")
                {
                    lighthouseMonkey.Caught();
                }
            }
        }

        // always passive raycasting
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "GreetingMonkey" && hit.distance < 5)
            {
                fuckingMonkey.SetActive(true);
            }
            else
            {
                fuckingMonkey.SetActive(false);
            }
        }
    }

    private void HandTimer()
    {
        if (leftClickTimer > 0 && Time.time - leftClickTimer >= 1)
        {
            leftClickTimer = 0;
            hand.SetActive(false);
        }
    }
}
