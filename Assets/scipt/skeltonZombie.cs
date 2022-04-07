using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skeltonZombie : Enemi
{
    //private UnityEngine.AI.NavMeshAgent agentSkelton;
    
    
    

    public override void Start()
    {
        base.Start();   
        agent.speed = 5;
        or = 3;
        pv = 3;

    }

    
    

}
