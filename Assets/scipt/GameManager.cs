using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text txt_Timer;
    public Text txt_pv;
    private bool vie = false;
    private int pv = 3;
    public Spawner spawner;
    public float gameTimer = 0f;
    public Enemi enemi;
    public List<Enemi> listeEnnemi;
    private int or;
    public Button play;
    public Button Pause;
    // Start is called before the first frame update
    void Start()
    {
        Pause.onClick.AddListener(btn_pause_onClicked);
        play.onClick.AddListener(btn_play_onClicked);
        or = 2;
        txt_pv.text = pv.ToString();
        
        spawner.ennemiSpawn();


        
        
    }

    // Update is called once per frame
    void Update()
    {

        timer();
       
        listeEnnemi = spawner.listeEnnemi;
        
    }
    public void loseLife()
    {
            
        pv -=1;
        txt_pv.text = pv.ToString();
        if(pv == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
    private void btn_pause_onClicked()
    {
        Time.timeScale = 0;
    }

private void btn_play_onClicked()
    {
        Time.timeScale = 1;
    }


    
    




}
