using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Warlock : Enemi
{
    protected override void Start()
    {
        base.Start();
        agent.speed = 3;
        or = 3;
        pv = 7;
        

    }

    public override void EnnemiToucher()
    {
        
        pv -= 1;

        if (pv == 0)
        {
            nbrKill += 1;
            Debug.Log(nbrKill);
            Destroy(gameObject);
            
        }
        
    }
   
}
