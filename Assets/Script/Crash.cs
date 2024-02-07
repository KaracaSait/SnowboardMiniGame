using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float crashTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", crashTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
