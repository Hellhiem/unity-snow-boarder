using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishLineReloadDelay = 1f;
    [SerializeField] ParticleSystem finishLineEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishLineEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke(nameof(ReloadScene), finishLineReloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
