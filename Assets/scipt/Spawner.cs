using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemi warrokPrefab;
    public Enemi nightshadePrefab;
    public Enemi squeltonzombieprefab;
    public bool spawnIsFinish = false;
    public List<Enemi> listeEnnemi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ennemiSpawn(int wave)
    {
        StartCoroutine(attendre(wave));
    }


    IEnumerator attendre(int wave)
    {
        
        spawnIsFinish = false;
        yield return new WaitForSeconds(10f);
        //fait spwaner les ennemis selon la vague et laiss 1 a 3 seconde entre chaque spawn d'ennemi
        for (int i = 0; i <= wave; i++)
        {

            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Enemi nightshade = Instantiate(nightshadePrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
            listeEnnemi.Add(nightshade);
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Enemi squeltonzombie = Instantiate(squeltonzombieprefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
            listeEnnemi.Add(squeltonzombie);
        }
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        Enemi warrok = Instantiate(warrokPrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        listeEnnemi.Add(warrok);
        yield return listeEnnemi;
        spawnIsFinish = true;
    }


    
}
