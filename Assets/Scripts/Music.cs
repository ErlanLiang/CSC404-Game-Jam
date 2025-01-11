using UnityEngine;

public class Music : MonoBehaviour
{   
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip BGM;
    [SerializeField] private player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.clip = BGM;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
