using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject gameObjectTarget;

    NavMeshAgent navMeshAgent;

    bool hasOnce;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasOnce && navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {

            hasOnce = true;
            navMeshAgent.SetDestination(gameObjectTarget.transform.position);
        }
    }
}
