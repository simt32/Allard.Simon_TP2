using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDuChemin : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        //si le gameobject entre en colision avec un ennemi
        //on detrui l'ennemi
        if(other.gameObject.tag == "Ennemi")
        {
            Debug.Log("sa marche");
            Destroy(other.gameObject);
            //apelle de la fonction lose life qui permet de perdre une vie au joueur
            gameManager.loseLife();
            
        }
    }
}
