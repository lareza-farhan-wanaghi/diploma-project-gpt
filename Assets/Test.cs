using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    Transform target;

    NavMeshAgent nma;
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        nma.updateRotation = false;
        nma.updateUpAxis = false;
        target = GameObject.Find("target").transform;
        nma.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (nma.remainingDistance <= nma.stoppingDistance)
        {
            Debug.Log("reached destination");

        }
    }
}
