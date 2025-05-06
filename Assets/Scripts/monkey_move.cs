using UnityEngine;
using UnityEngine.InputSystem;

public class monkey_move : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            animator.SetBool("dance", true);
            animator.SetBool("groin", false);
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            animator.SetBool("dance", false);
            animator.SetBool("groin", true);
        }
    }
}
