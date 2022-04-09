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
        Vector3 positionEnemi = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(positionEnemi);
        Vector3 rotation = Quaternion.Lerp(Gun_Mid.rotation, lookRotation, Time.deltaTime * turnspeed).eulerAngles;
        Gun_Mid.rotation = Quaternion.Euler(-90f,rotation.y,0f);
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
        }

    }
    void Toucher()
    {
        
        if (ennemii.name == "warrok(Clone)")
        {
            FindObjectOfType<Warlock>().EnnemiToucher();
        }
        if (ennemii.name == "skeletonzombie(Clone)")
            FindObjectOfType<skeltonZombie>().EnnemiToucher();
        if (ennemii.name == "nightshade(Clone)")
        {
            
            FindObjectOfType<NightShade>().EnnemiToucher();
        }       
    }
    


}
