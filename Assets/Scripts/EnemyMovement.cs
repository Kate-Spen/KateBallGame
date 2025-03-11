using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Animator anim;

    // Reference to the player's transform.
    public Transform player;

    // Reference to the NavMeshAgent component for pathfinding.
    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the NavMeshAgent component attached to this object.
        navMeshAgent = GetComponent<NavMeshAgent>();

        //Get the animator component
        anim = GetComponentInChildren<Animator>();
        //Set the value of speed_f
        if (anim)
        {
            anim.SetFloat("speed_f", navMeshAgent.speed);
        }
    }

    // Update is called once per frame.
    void Update()
    {
        // If there's a reference to the player...
        if (player != null)
        {
            // Set the enemy's destination to the player's current position.
            navMeshAgent.SetDestination(player.position);
        }
    }
}
