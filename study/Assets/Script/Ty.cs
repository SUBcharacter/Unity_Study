using UnityEngine;

public class Ty : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ChangeState();
    }

    void ChangeState()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Running");
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Die");
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Revive");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Attack");
        }
    }

}
