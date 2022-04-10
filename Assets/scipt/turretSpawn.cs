using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turretSpawn : MonoBehaviour
{
    public GameObject turretBasePrefab;
    public GameObject turret_Gun_Prefab;
    public GameObject turret_Slower_Prefab;
    public GameObject turret_Cannon_Prefab;
    GameObject turret_slower;
    public GameObject cube;
    public Button slower;
    public Button cannon;
    public Button gun;
    public Button cancel;
    public Button vendre;
    public Transform Base;
    private GameObject test;
    private bool click = true;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
        //ajout des listener sur les boutons
        slower.onClick.AddListener(btn_Slower_onClicked);
        cannon.onClick.AddListener(btn_Cannon_onClicked);
        gun.onClick.AddListener(btn_Gun_onClicked);
        cancel.onClick.AddListener(btn_Cancel_onClicked);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (click)
        {
            //si on click sur la souris on trouve ou on a cliker
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit raycastHit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    if (raycastHit.transform != null)
                    {
                        test = raycastHit.transform.gameObject;                        
                        CurrentClickedGameObject(raycastHit.transform.gameObject);
                    }
                }
            }
        }
    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        //si la tourelle que on a cliker a le bon tag on affiche le menu de selection de tourelle
        if (gameObject.tag == "TurretBase")
        {
            test = gameObject;

            slower.gameObject.SetActive(true);
            cannon.gameObject.SetActive(true);
            gun.gameObject.SetActive(true);
            cancel.gameObject.SetActive(true);
           
            //gameObject.tag = "occuper";
            click = false;
        }
    }
    //on fait apparaitre la tourelle qui a été cliker et on fait dissparaitre la menu
    //le tag de la tourelle est mainetant occuper
    //on fait la meme chose pour les 2 autre bouton
    void btn_Slower_onClicked()
    {
        turret_slower = Instantiate(turret_Slower_Prefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        //Debug.Log(test.transform.position);
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        test.tag = "occuper";
        
        click = true;
        
    }
    void btn_Gun_onClicked()
    {
        Instantiate(turret_Gun_Prefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        test.tag = "occuper";
        click = true;
    }
    void btn_Cannon_onClicked()
    {
        Instantiate(turret_Cannon_Prefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        //Debug.Log(test.transform.position);
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        test.tag = "occuper";
        click = true;
    }
    //annule la selection de tourelle
    //fait disparaitre le menu de selection
    void btn_Cancel_onClicked()
    {
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        vendre.gameObject.SetActive(false);
        test.tag = "TurretBase";
        click = true;
    }

}
