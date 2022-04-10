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
        pv = 4;
    }
    //est appeler quand le warrok est toucher 
    public override void EnnemiToucher()
    {
        pv -= 1;
        //si il na plus de pv on fait jouer le clip audio de mort et on le detrui dans une co routine apres
        if (pv == 0)
        {
            source.PlayOneShot(AudioMort);
            nbrKill += 1;
            StartCoroutine(attendre());
        }

        IEnumerator attendre()
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
    }
}
