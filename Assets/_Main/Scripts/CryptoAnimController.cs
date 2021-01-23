using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class CryptoAnimController : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    Transform target;
    //  [SerializeField]
    // TwoBoneIKConstraint IK;
    [SerializeField]
    Rig headRig;
    [SerializeField]
    Rig chestRig;

    Vector3 mousePosition;
    bool isLookingAtEthan = false;
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Mathf.Abs(transform.position.z * 2))); // target is always in front of character unless it rotates using animation
        target.position = mousePosition;

        CheckInput();

    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isLookingAtEthan)
            {
                headRig.weight = 0;
                chestRig.weight = 0;
            }
            else
            {
                headRig.weight = 1;
                chestRig.weight = 1;
            }
            isLookingAtEthan = !isLookingAtEthan;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Kick");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Forward", 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetFloat("Forward", 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("Forward", -0.5f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetFloat("Forward", 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Turn", -0.5f);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetFloat("Turn", 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Turn", 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetFloat("Turn", 0);
        }
    }
}
