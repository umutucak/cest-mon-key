using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Ray ray;
    Camera camera;
    public GameObject fuckingMonkey;
    public GreetingSpeech greetingSpeech;
    public LightHouseMonkey lighthouseMonkey;
    public BoatMonkey boatMonkey;
    public RockMonkey rockMonkey;
    public MountainMonkey mountainMonkey;
    public TreeMonkey treeMonkey;
    public GameObject leftHand;
    public GameObject rightHand;
    public Boat boat;
    public Announcer announcer;
    public Door1 door1;
    public Door2 door2;
    public Tent tent;
    public Campfire campfire;

    private float leftHandTimer = 0;
    private float rightHandTimer = 0;

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
            leftHandTimer = Time.time;
            leftHand.SetActive(true);
            if (Physics.Raycast(ray, out hit, 5))
            {
                if (hit.collider.name == "GreetingMonkey")
                {
                    greetingSpeech.ContinueDialogue();
                }
                else if (hit.collider.name == "WoodBoat")
                {
                    boat.LiftOff();
                    boatMonkey.gameObject.SetActive(true);
                }
                else if (hit.collider.name == "BoatMonkey")
                {
                    boatMonkey.Caught();
                }
                else if (hit.collider.name == "RockMonkey")
                {
                    rockMonkey.Caught();
                }
                else if (hit.collider.name == "Door1" && !door1.triggered)
                {
                    door1.triggered = true;
                    announcer.Play("block");
                }
                else if (hit.collider.name == "Door2" && !door2.triggered)
                {
                    door2.triggered = true;
                    announcer.Play("block");
                }
                else if (hit.collider.name == "Tent" && !tent.triggered)
                {
                    tent.triggered = true;
                    announcer.Play("block");
                }
                else if (hit.collider.name == "CampFire" && !campfire.triggered)
                {
                    campfire.triggered = true;
                    announcer.Play("block");
                }
            }
            return;
        }
        // if left click
        if (Input.GetMouseButtonDown(0))
        {
            rightHandTimer = Time.time;
            rightHand.SetActive(true);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "LightHouseMonkey")
                {
                    lighthouseMonkey.Caught();
                }
                else if (hit.collider.name == "MountainMonkey")
                {
                    mountainMonkey.Caught();
                }
                else if (hit.collider.name == "TreeMonkey")
                {
                    treeMonkey.Caught();
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
        if (leftHandTimer > 0 && Time.time - leftHandTimer >= 1)
        {
            leftHandTimer = 0;
            leftHand.SetActive(false);
        }
        if (rightHandTimer > 0 && Time.time - rightHandTimer >= 1)
        {
            rightHandTimer = 0;
            rightHand.SetActive(false);
        }
    }
}
