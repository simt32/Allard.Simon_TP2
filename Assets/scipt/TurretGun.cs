using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour
{
    public Transform target;
    public float range = 15f;
    public Transform Gun_Mid;
    
    public float cadence = 1f;
    private float delai = 0f;
    private float turnspeed = 6.5f;
    public Spawner spawner;
    public GameObject ennemii;
    public ParticleSystem psShoot;
    public AudioClip audioClipShoot;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        InvokeRepeating("UpdateTarget", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            return;
        }
        //if (delai <= 0f)
        //{

        //    Toucher();
        //    delai = 1 / cadence;
        //}
        //delai -= Time.deltaTime;
        Vector3 positionEnemi = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(positionEnemi);
        Vector3 rotation = Quaternion.Lerp(Gun_Mid.rotation, lookRotation, Time.deltaTime * turnspeed).eulerAngles;
        Gun_Mid.rotation = Quaternion.Euler(-90f,rotation.y,0f);
      

        //foreach (GameObject ennemi in ennemis)
        //{
        //    float distanceToEnemis = Vector3.Distance(transform.position, ennemi.transform.position);
        //    if (ennemi != null && distanceToEnemis <= range)
        //    {

        //        target = ennemi.transform;
        //        //Debug.Log(target);
        //        InvokeRepeating("Toucher", 2f,2f);


        //    }
        //    else
        //    {
        //        target = null;
        //    }
        //}

    }

    void UpdateTarget()
    {

        
        GameObject[] ennemis = GameObject.FindGameObjectsWithTag("Ennemi");
       
        foreach (GameObject ennemi in ennemis)
        {
            float distanceToEnemis = Vector3.Distance(transform.position, ennemi.transform.position);           
            if(ennemi != null && distanceToEnemis<= range)
            {
                ennemii = ennemi;
                //Debug.Log(ennemi.name);
                target = ennemi.transform;
                Toucher();
                psShoot.Play();
                source.PlayOneShot(audioClipShoot);
                

            }
            //else
            //{
            //    Debug.Log("le target est null");
            //    target = null;
            //    ennemis = null;
            //    break;
            //}
        }

    }
    void Toucher()
    {
        Debug.Log(ennemii.name);
        if (ennemii.name == "warrok(Clone)")
        {
           
            FindObjectOfType<Warlock>().EnnemiToucher();
        }
            
        if (ennemii.name == "skeletonzombie(Clone)")
            FindObjectOfType<skeltonZombie>().EnnemiToucher();
        if (ennemii.name == "nightshade(Clone)")
        {
            Debug.Log(ennemii.name);
            FindObjectOfType<NightShade>().EnnemiToucher();
        }
            


    }
    


}
