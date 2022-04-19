using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _nav;
    [SerializeField] private Transform pos;


    private void Start()
    {
        _nav.SetDestination(pos.position);
    }

    void Update()
    {
        
    }
}
