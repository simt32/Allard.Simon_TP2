using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turretSpawn : MonoBehaviour
{
    public GameObject turretBasePrefab;
    public GameObject turretPrefab;
    public GameObject slowerPrefab;
    public Button slower;
    public Button cannon;
    public Button gun;
    public Transform Base;
    private GameObject test;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        
        slower.onClick.AddListener(btn_Slower_onClicked);
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

                    
                    test = raycastHit.transform.gameObject;
                    Debug.Log(raycastHit.transform.gameObject);
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                    
                    
                }
            }
        }

    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        
        if (gameObject.tag == "TurretBase")
        {
            test = gameObject;
            slower.gameObject.SetActive(true);
            cannon.gameObject.SetActive(true);
            gun.gameObject.SetActive(true);
            Debug.Log(gameObject);
            Debug.Log("sa marche");
            //Instantiate(turretPrefab, gameObject.transform.position,new Quaternion(-90f,0f,0f,90f));
            Debug.Log(gameObject.transform.position);
            gameObject.tag = "occuper";

        }
    }


    void btn_Slower_onClicked()
    {
        
        Debug.Log("bouton click");
        Instantiate(slowerPrefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        Debug.Log(test.transform.position);
        
    }
}
