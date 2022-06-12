using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public AudioClip Enemydeath;
    public AudioClip Fruitsound;
    public AudioClip Boxsound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void PlayClip()
    {
        source.clip = clip;
        source.Play();
    }
    public void PlayClipEnemy()
    {
        source.clip = Enemydeath;
         source.Play();
    }
    public void PlayClipFruit()
    {
        source.clip = Fruitsound;
        source.Play();
    }
    public void PlayClipBox()
    {
        source.clip = Boxsound;
        source.Play();
    }
}
