using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
    }
}