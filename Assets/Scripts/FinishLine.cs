using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //Reload scene after player hits finish point and restart the level
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delayTime);         
        }  
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
