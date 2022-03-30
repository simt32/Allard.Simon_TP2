using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    //agent en d�placement ou en pause
    bool isBusy;
    // Start is called before the first frame update
    void Start()
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
    }

    IEnumerator test()
    {
        isBusy = true;

        //trouver un edestination
        Vector3 destination = getDestination();

        //s'y d�placer
        agent.SetDestination(destination);



        //tant quon est en d�placement on ne fait rien
        //while (agent.pathPending || agent.remainingDistance > 0.5f)

        yield return null;




        //je ne suis plus occuper

        isBusy = false;
    }

    Vector3 getDestination()
    {
        //-11.5 a 7.5
        float x = 10.2f;

        float z = -57.25f;



        return new Vector3(x, 0.6f, z);
    }
}
