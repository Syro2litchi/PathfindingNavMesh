using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPathfinding : MonoBehaviour
{
    [Header("NavMesh Destination")]
    [SerializeField] private Transform _destination;
    
    private Animator _animator;
    private NavMeshAgent _agent;
    
    private float _xVelocity;
    private float _yVelocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_destination.transform.position);
        
        _animator.SetFloat("XVelocity", _agent.angularSpeed);
        _animator.SetFloat("YVelocity", _yVelocity);
        _animator.SetFloat("ZVelocity", _agent.velocity.normalized.magnitude);
    }
}