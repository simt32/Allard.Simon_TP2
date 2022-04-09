using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Enemi : MonoBehaviour
{
    public int or;
    public int pv;
    public UnityEngine.AI.NavMeshAgent agent;
    
    //agent en d�placement ou en pause
    bool isBusy;

    
    
    
    protected virtual void Start()
    {
        
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    
    protected virtual void Update()
    {
        if (!isBusy)
        {
            StartCoroutine(deplacement());
        }
    }

    IEnumerator  deplacement()
    {
        isBusy = true;

        //trouver une destination
        Vector3 destination = getDestination();

        //si deplacer
        agent.SetDestination(destination);


        //tant quon est en deplacement on ne fait rien
        while (agent.pathPending || agent.remainingDistance > 0.5f)

        yield return null;




        //je ne suis plus occuper

        isBusy = false;
    }

    Vector3 getDestination()
    {
        //decider de la position
        float x = 15.72f;
        float z = -50.89f;
        return new Vector3(x, 0.6f, z);
    }
    public virtual void EnnemiToucher()
    {

    }


}
