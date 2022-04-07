using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject warrokPrefab;
    public GameObject nightshadePrefab;
    public GameObject squeltonzombieprefab;
    //public Enemi enemi;
    skeltonZombie skeltonZombie;
    
    
    private int nbr_ennemi;
    int wave = 1;
    bool ispawn = true;
    private List<GameObject> listeEnnemi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ennemiSpawn()
    {
        StartCoroutine(attendre());

        
        

        
        
           
    }


    IEnumerator attendre()
    {
        GameObject warrok = Instantiate(warrokPrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        
        yield return new WaitForSeconds(Random.Range(1f,6f));
        GameObject nightshade = Instantiate(nightshadePrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        
        yield return new WaitForSeconds(Random.Range(1f, 6f));
        GameObject squeltonzombie = Instantiate(squeltonzombieprefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
       




        nbr_ennemi += 3;





    }
}
