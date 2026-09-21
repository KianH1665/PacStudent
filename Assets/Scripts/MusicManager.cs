using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
    public AudioSource musicSource;
    public AudioClip introClip;
    public AudioClip normalClip;
    
    void Start()
    {
        StartCoroutine(PlayIntroThenNormal());
    }

    IEnumerator PlayIntroThenNormal() {
        musicSource.clip = introClip;
        musicSource.loop = false;
        musicSource.Play();

        yield return new WaitForSeconds(3f);

        musicSource.clip = normalClip;
        musicSource.loop = true;
        musicSource.Play();
    }
}