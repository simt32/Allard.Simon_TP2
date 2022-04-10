using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text txt_Timer;
    public Text txt_pv;
    public Text txt_wave;
    public Text txt_tuer;
    public GameObject txt_gameOver;
    private int pv = 3;
    public Spawner spawner;
    private float gameTimer = 0f;
    public Enemi enemi;
    public List<Enemi> listeEnnemi;
    public Button play;
    public Button Pause;
    private int tuer;
    private int wave;
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Pause.onClick.AddListener(btn_pause_onClicked);
        play.onClick.AddListener(btn_play_onClicked);
        txt_wave.text = wave.ToString();
        txt_pv.text = pv.ToString();
        spawner.ennemiSpawn(wave);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            return;
        tuer = enemi.nbrKill;
        
        txt_tuer.text = tuer.ToString();
        if (spawner.spawnIsFinish)
        {
            //si il ny a plus d'ennemi on en fait spawner d'autre et on augmente la vague de 1
            if (GameObject.Find("warrok(Clone)") == null && GameObject.Find("sketonzombie(Clone)") == null && GameObject.Find("nightshade(Clone)") == null)
            {
                wave += 1;
                txt_wave.text = wave.ToString();
                spawner.ennemiSpawn(wave);
            }
        }
        timer();
    }
    //methode appeller si un ennemi entre dans le collider pres du chateau
    //le joueur perd une vie et si il a 0 vie il perd la partie
    public void loseLife()
    {
        pv -=1;
        txt_pv.text = pv.ToString();
        if(pv == 0)
        {
            isGameOver = true;
            Time.timeScale = 0;
            txt_gameOver.SetActive(true);
        }
    }
    //affiche un timer avec les secondes,les minutes et les heures
    void timer()
    {
        gameTimer += Time.deltaTime;
        int seconde = (int)(gameTimer % 60);
        int minute = (int)(gameTimer / 60) % 60;
        int heure = (int)(gameTimer / 3600) % 24;
        string timerstring = string.Format("{0:0}:{1:00}:{2:00}", heure, minute, seconde);
        txt_Timer.text = timerstring;
    }
    //permet de mettre le jeux en pause
    private void btn_pause_onClicked()
    {
        Time.timeScale = 0;
    }
    //permet de reprendre la parti
    private void btn_play_onClicked()
    {
        Time.timeScale = 1;
    }


    
    




}
