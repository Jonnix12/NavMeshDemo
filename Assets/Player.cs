using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _nav;
    [SerializeField] private Transform pos;

    [SerializeField] private ThirdPersonCharacter _character;
    
    private void Start()
    {
        _nav.updateRotation = false;
        
        _nav.SetDestination(pos.position);
    }

    void Update()
    {
        if (_nav.remainingDistance > _nav.stoppingDistance)
        {
            _character.Move(_nav.desiredVelocity, false);
        }
        else
        {
            _character.Move(Vector3.zero,false);
        }
    }
}
