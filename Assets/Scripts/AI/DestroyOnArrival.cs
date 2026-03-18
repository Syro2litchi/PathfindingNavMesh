using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    public class DestroyOnArrival : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private NavMeshPathfinding _pathfinding;
        private Vector2 _destination;
    
        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _destination = new Vector2(_agent.destination.x, _agent.destination.z);
        }

        void Update()
        {
            if (_destination == new Vector2(gameObject.transform.position.x, gameObject.transform.position.z))
            {
                Destroy(gameObject, 0.8f);
            }
        }
    }
}

