using UnityEngine;

public class PenguinAnimController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMovingUp", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("IsMovingUp", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsMovingDown", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("IsMovingDown", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsMovingRight", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("IsMovingRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("IsMovingLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("IsMovingLeft", false);
        }
    }
}
