using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Ray ray;
    Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(Input.GetMouseButtonDown(0));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left-click.");
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 10))
            {
                Transform objectHit = hit.transform;
                Debug.Log(objectHit);
            }

        }
    }
}
