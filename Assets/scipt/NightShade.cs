using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NightShade :Enemi
{
    public int vitesse = 3;
    protected override void Start()
    {
        base.Start();
        agent.speed = 2;
        or = 3;
        pv = 5;

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

