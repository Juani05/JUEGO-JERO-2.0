using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip motodied;
    public AudioSource fuenteaudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playclip()
    {
        fuenteaudio.clip = motodied;
        fuenteaudio.Play();
    }
}
