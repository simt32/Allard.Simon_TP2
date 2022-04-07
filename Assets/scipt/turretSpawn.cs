using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretSpawn : MonoBehaviour
{
    public GameObject turretBasePrefab;
    public GameObject turretPrefab;
    public Transform Base;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    
                    //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }

    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        
        if (gameObject.tag == "TurretBase")
        {
           
            Debug.Log(gameObject);
            Debug.Log("sa marche");
            Instantiate(turretPrefab, gameObject.transform.position,new Quaternion(-90f,0f,0f,90f));
            gameObject.tag = "occuper";

        }
    }
}
