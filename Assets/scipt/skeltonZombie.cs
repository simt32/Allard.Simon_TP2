using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skeltonZombie : Enemi
{
    
    //private UnityEngine.AI.NavMeshAgent agentSkelton;
    
    
    

    protected override void Start()
    {
        base.Start();   
        agent.speed = 3;
        or = 3;
        pv = 3;
        
    }

    protected override void Update()
    {

        base.Update();
        
        
        
       
    }
    public override void EnnemiToucher()
    {
        Debug.Log("toucher");
        pv -= 1;

        if (pv == 0)
        {
            Destroy(gameObject);

        }




    }
}

