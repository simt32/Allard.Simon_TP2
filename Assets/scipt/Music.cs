using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] music;
    public AudioSource source;
   
    // Start is called before the first frame update
    void Start()
    {
        //source = FindObjectOfType<AudioSource>();
        source.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        //si la music ne jou plus on fait jouer une autre music
        if (!source.isPlaying)
        {
            source.clip = GetRandomClip();
            source.Play();
        }
        
    }
    //trouve une music al/atoir parmis la liste des musics
    private AudioClip GetRandomClip()
    {
        return music[Random.Range(0, music.Length)];
    }

    
}
