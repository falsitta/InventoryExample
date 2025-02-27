using UnityEngine;

public class JamesAnimationEvents : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public AudioSource audioSource;
    public AudioClip kickWhoosh;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation()
    {
        animator.Play("HighKick");
    }

    public void SpawnParticle()
    {
        particleSystem.Play();
    }

    public void PlaySoundEffect()
    {
        audioSource.PlayOneShot(kickWhoosh);
    }



    private void OnMouseDown()
    {
        Debug.Log("CLicked james");
    }
}
