using UnityEngine;

public class SFX : MonoBehaviour
{
    [SerializeField] private AudioClip fanning;
    [SerializeField] private AudioClip drink;
    [SerializeField] private AudioClip clap;
    [SerializeField] private AudioClip truck;
    [SerializeField] private AudioClip death;

    public void PlayFanning()
    {
        AudioSource.PlayClipAtPoint(fanning, Camera.main.transform.position);
    }

    public void PlayDrink()
    {
        AudioSource.PlayClipAtPoint(drink, Camera.main.transform.position);
    }

    public void PlayClap()
    {
        AudioSource.PlayClipAtPoint(clap, Camera.main.transform.position);
    }

    public void PlayTruck()
    {
        AudioSource.PlayClipAtPoint(truck, Camera.main.transform.position);
    }

    public void PlayDeath()
    {
        AudioSource.PlayClipAtPoint(death, Camera.main.transform.position);
    }

}