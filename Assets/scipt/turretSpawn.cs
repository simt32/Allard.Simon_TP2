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
    private bool btn_VendreIsActive = false;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");

        slower.onClick.AddListener(btn_Slower_onClicked);
        cannon.onClick.AddListener(btn_Cannon_onClicked);
        gun.onClick.AddListener(btn_Gun_onClicked);
        cancel.onClick.AddListener(btn_Cancel_onClicked);
        vendre.onClick.AddListener(btn_Vendre_onClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (click)
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
                        
                        //Debug.Log(raycastHit.transform.gameObject);
                        CurrentClickedGameObject(raycastHit.transform.gameObject);


                    }
                }
            }
        }
        

    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        //if (gameObject.tag == "occuper")
        //{
        //    vendre.gameObject.SetActive(true);
        //    cancel.gameObject.SetActive(true);
        //    btn_VendreIsActive = true;
        //    test = gameObject;
        //}
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


    void btn_Slower_onClicked()
    {
        
        Debug.Log("bouton click");
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

        Debug.Log("bouton click");
        Instantiate(turret_Gun_Prefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        
        //Debug.Log(test.transform.position);
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        test.tag = "occuper";

        click = true;

    }

    void btn_Cannon_onClicked()
    {

        Debug.Log("bouton click");
        Instantiate(turret_Cannon_Prefab, test.transform.position, new Quaternion(-90f, 0f, 0f, 90f));
        //Debug.Log(test.transform.position);
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        test.tag = "occuper";

        click = true;

    }
    void btn_Cancel_onClicked()
    {
        //Debug.Log("bouton click");
        //if (btn_VendreIsActive)
        //{
        //    test.tag = "occuper";
        //}
        //Debug.Log(test.transform.position);
        slower.gameObject.SetActive(false);
        cannon.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        vendre.gameObject.SetActive(false);
        test.tag = "TurretBase";
        //if (!btn_VendreIsActive)
        //{
        //    test.tag = "TurretBase";
        //}
        
        click = true;

    }
    void btn_Vendre_onClicked()
    {
        Debug.Log("bouton click");

        //Debug.Log(test.transform.position);
        cancel.gameObject.SetActive(false);
        vendre.gameObject.SetActive(false);
        
        
        Debug.Log(test.tag);
        Destroy(turret_slower);
        
        click = true;
        btn_VendreIsActive = false;
        test.tag = "TurretBase";

    }

}
