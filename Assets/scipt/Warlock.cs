using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Warlock : Enemi
{
    int vitesse = 3;
    public void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3;
    }
}
