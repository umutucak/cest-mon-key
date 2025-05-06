using UnityEngine;

public class monkey_move : MonoBehaviour
{
    Animator playerAnim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerAnim.SetBool("dance", true);
            playerAnim.SetBool("groin", false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerAnim.SetBool("dance", false);
            playerAnim.SetBool("groin", true);
        }
    }
}
