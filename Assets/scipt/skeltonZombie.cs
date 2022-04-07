using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skeltonZombie : Enemi
{
    //private UnityEngine.AI.NavMeshAgent agentSkelton;
    
    
    public int or = 3;
    public int pv;



    public void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.speed = 5;
    }
    

}
