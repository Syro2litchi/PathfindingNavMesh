using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class NavMeshPathfinding : MonoBehaviour
{
    [Header("NavMesh Destination")]
    [SerializeField] private List<GameObject> _destination;
    
    private Animator _animator;
    private NavMeshAgent _agent;

    private int _selectedDestination;
    private float _xVelocity;
    private float _yVelocity;
        
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
        // _selectedDestination = Random.Range(0, _destination.Count);
        // _agent.SetDestination(_destination[_selectedDestination].transform.position);
    }


    void Start()
    {
        Debug.Log(_agent.destination);
    }
    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("XVelocity", _agent.angularSpeed);
        _animator.SetFloat("YVelocity", _yVelocity);
        _animator.SetFloat("ZVelocity", _agent.velocity.normalized.magnitude);
    }
}