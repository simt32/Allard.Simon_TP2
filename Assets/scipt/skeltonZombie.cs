using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skeltonZombie : Enemi
{
    //public AudioClip AudioMort;
    //public AudioSource source;
    //private UnityEngine.AI.NavMeshAgent agentSkelton;




    protected override void Start()
    {
        
        base.Start();
        source = FindObjectOfType<AudioSource>();
        agent.speed = 3;
        or = 3;
        pv = 3;
        
    }

    protected override void Update()
    {

        base.Update();
        
        
        
       
    }
    //est appeler quand le skelton est toucher 
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
        IEnumerator attendre()
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }



    }
}

