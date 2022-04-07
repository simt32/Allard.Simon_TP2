using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemi warrokPrefab;
    public Enemi nightshadePrefab;
    public Enemi squeltonzombieprefab;
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
        Enemi warrok = Instantiate(warrokPrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        
        yield return new WaitForSeconds(Random.Range(1f,6f));
        Enemi nightshade = Instantiate(nightshadePrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        
        yield return new WaitForSeconds(Random.Range(3f, 9f));
        Enemi squeltonzombie = Instantiate(squeltonzombieprefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
       




        nbr_ennemi += 3;





    }
}
