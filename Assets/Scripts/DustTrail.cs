using UnityEngine;

public class DustTrail : MonoBehaviour
{
    //Trail effects created when you jump and land down
    [SerializeField] ParticleSystem impactEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            impactEffect.Play();
        }     
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            impactEffect.Stop();
        }
    }
}
