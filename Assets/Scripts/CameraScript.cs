using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Ray ray;
    Camera camera;
    public GameObject fuckingMonkey;
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
        // if left click
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 5))
            {
                Transform objectHit = hit.transform;
            }
            return;
        }

        // always passive raycasting
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "GreetingMonkey" && hit.distance < 5)
            {
                fuckingMonkey = hit.transform.Find("InteractionText").gameObject;
                fuckingMonkey.SetActive(true);
            }
            else
            {
                fuckingMonkey.SetActive(false);
            }
        }
    }
}
