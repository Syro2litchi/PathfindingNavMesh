using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    public class NavMeshPathfinding : MonoBehaviour
    {
        private Animator _animator;
        private NavMeshAgent _agent;
        private GameObject _player;

    
        private bool _touchedPlayer;
    
        
        void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
            _animator = GetComponentInChildren<Animator>();
        }
    
        // Update is called once per frame
        void Update()
        {
            _animator.SetFloat("ZVelocity", _agent.velocity.normalized.magnitude);
            if (_touchedPlayer)
            {
                _agent.SetDestination(_player.transform.position);
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _player = other.gameObject;
                _touchedPlayer = true;
            }
        }
    }
}
