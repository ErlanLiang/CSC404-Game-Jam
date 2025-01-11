using UnityEngine;

public class SFX : MonoBehaviour
{
    [SerializeField] private AudioClip waterBottle;
    [SerializeField] private AudioClip fanning;

    public void PlayWaterBottle()
    {
        AudioSource.PlayClipAtPoint(waterBottle, Camera.main.transform.position);
    }

    public void PlayFanning()
    {
        AudioSource.PlayClipAtPoint(fanning, Camera.main.transform.position);
    }

}