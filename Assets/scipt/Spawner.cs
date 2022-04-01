using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject warrokPrefab;
    public GameObject nightshadePrefab;
    public GameObject squeltonzombieprefab;
    int wave = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ennemiSpawn()
    {
        GameObject warrok = Instantiate(warrokPrefab, new Vector3(-11f,0.6f, 57f), Quaternion.identity);
        GameObject nightshade = Instantiate(nightshadePrefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
        GameObject squeltonzombie = Instantiate(squeltonzombieprefab, new Vector3(-11f, 0.6f, 57f), Quaternion.identity);
    }
}

