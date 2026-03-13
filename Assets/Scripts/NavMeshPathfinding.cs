using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class NavMeshPathfinding : MonoBehaviour
{
    private Animator _animator;
    private NavMeshAgent _agent;

    private int _selectedDestination;
        
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
    }


    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("ZVelocity", _agent.velocity.normalized.magnitude);

        _agent.Raycast(_agent.destination, out NavMeshHit hit);
        
    }
}