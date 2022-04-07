using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Enemi : MonoBehaviour
{
    
    public UnityEngine.AI.NavMeshAgent agent;
    public int vitess = 1;
    //agent en d�placement ou en pause
    bool isBusy;

    // Start is called before the first frame update
    
    
    public void Start()
    {
        
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBusy)
        {
            StartCoroutine(test());
        }
        //if (loseLife())
        //{
            //findObjectOfType<GameManager>().loseLife(true);
        //}
    }

    IEnumerator test()
    {
        isBusy = true;

        //trouver un edestination
        Vector3 destination = getDestination();

        //s'y d�placer
        agent.SetDestination(destination);


        //tant quon est en d�placement on ne fait rien
        while (agent.pathPending || agent.remainingDistance > 0.5f)

        yield return null;




        //je ne suis plus occuper

        isBusy = false;
    }

    Vector3 getDestination()
    {
        //trouve la position qu'il doit se rendre
        float x = 15.72f;
        float z = -50.89f;
        return new Vector3(x, 0.6f, z);
    }
    //public bool loseLife()
    //{
        
        //if (agent.remainingDistance > 0.5f)
        //{
            
            //return false;
        //}
            
            
        //else
        //{
            //Destroy(agent);
            //return true;
        //}


    //}
}
