using UnityEngine;
using UnityEngine.AI;

public class MonsterChase : MonoBehaviour
{
    public Transform player;
    public float chaseDistance = 10f;

    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= chaseDistance)
        {
            agent.SetDestination(player.position);
            animator.SetBool("isWalking", true);
        }
        else
        {
            agent.ResetPath();
            animator.SetBool("isWalking", false);
        }
    }
}
