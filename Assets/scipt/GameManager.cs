using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Text txt_pv;
    private bool vie = false;
    public Enemi enemi;
    private int pv = 3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        txt_pv.text = pv.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        loseLife(vie);
    }
    public void loseLife(bool vie)
    {
        
            if (vie == true)
            {
                pv -=1;
                txt_pv.text = pv.ToString();
            Debug.Log("test");
            }
                
           
    }
    




}
