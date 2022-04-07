using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NightShade :Enemi
{
    public int vitesse = 3;
    public void Awake()
    {
        vitesse = 4;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 4;
    }
}
