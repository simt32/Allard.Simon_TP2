using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text txt_Timer;
    public Text txt_pv;
    private bool vie = false;
    private int pv = 3;
    public Spawner spawner;
    public float gameTimer = 0f;
    public Enemi enemi;
    
    // Start is called before the first frame update
    void Start()
    {
        
        txt_pv.text = pv.ToString();
        //txt_Timer.text = timerStart.ToString("F2");
        spawner.ennemiSpawn();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer();
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

    void timer()
    {
        gameTimer += Time.deltaTime;
        int seconde = (int)(gameTimer % 60);
        int minute = (int)(gameTimer / 60) % 60;
        int heure = (int)(gameTimer / 3600) % 24;
        string timerstring = string.Format("{0:0}:{1:00}:{2:00}", heure, minute, seconde);
        txt_Timer.text = timerstring;
    }
    




}