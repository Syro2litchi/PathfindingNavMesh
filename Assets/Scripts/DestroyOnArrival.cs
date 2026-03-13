using UnityEngine;
using UnityEngine.AI;

public class DestroyOnArrival : MonoBehaviour
{
    private NavMeshAgent agent;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Destroy(gameObject, 0.8f);
        }
    }
}
