using UnityEngine;
using TMPro;

public class LightHouseMonkey : MonoBehaviour
{
    // public LightHouseMonkey me;
    Animator animator;
    public TMP_Text tmp;
    public Announcer announcer;
    float time = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // // Debug.Log
        if (time > 0 && Time.time - time >= 7)
        {
            time = 0;
            gameObject.SetActive(false);
            
        }
    }

    public void Caught()
    {
        time = Time.time;
        tmp.text = "BUT IM NOT DOOOOOONEEEEEE";
        animator.SetBool("dance", false);
        animator.SetBool("groin", true);
        announcer.Play("monkey");
    }
}
