using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NightShade :Enemi
{
    
    //public AudioClip AudioMort;
    //public AudioSource source;
    protected override void Start()
    {
        base.Start();
        
        agent.speed = 2;
        or = 3;
        pv = 5;

    }

    //est appeler quand la nightshade est toucher 
    public override void EnnemiToucher()
    {
        
        pv -= 1;
        //si il na plus de pv on fait jouer le clip audio de mort et on le detrui dans une co routine apres
        if (pv == 0)
        {

            nbrKill += 1;
            source.PlayOneShot(AudioMort);
            StartCoroutine(attendre());
           

        }
    }
    IEnumerator attendre()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}

