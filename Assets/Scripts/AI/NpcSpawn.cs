using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

namespace AI
{
    public class NpcSpawn : MonoBehaviour
    {
        [SerializeField] private List<GameObject> targets;
        [SerializeField] private GameObject npc;

        private NavMeshAgent npcAgent;
    
        private float timer;
        private float randomTime;
    
        private int _selectedDestination;

        private void Awake()
        {
            npcAgent = npc.GetComponent<NavMeshAgent>();
            randomTime = Random.Range(0f, 50f);
        }

        private void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer >= randomTime)
            {
                SpawnNpcs();
                timer = 0f;
                randomTime = Random.Range(10f, 50f);
                _selectedDestination = Random.Range(0, targets.Count);
            }
        }

        private void SpawnNpcs()
        {
            npcAgent = Instantiate(npc, transform.position, Quaternion.identity).GetComponent<NavMeshAgent>();
            _selectedDestination = Random.Range(0, targets.Count);
            npcAgent.SetDestination(targets[_selectedDestination].transform.position);
        }
    }
}

