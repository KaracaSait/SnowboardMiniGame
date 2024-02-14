using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float crashTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrash = false;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && hasCrash == false)
        {
            hasCrash = true;
            FindObjectOfType<PlayerController>().DisableMove();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", crashTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
