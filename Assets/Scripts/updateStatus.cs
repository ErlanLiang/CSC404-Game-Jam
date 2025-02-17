using UnityEngine;
using UnityEngine.UI;
using System;
using FMODUnity;

public class Status : MonoBehaviour
{
    public float budyHeat = 50.0f;
    public float stamina = 50.0f;
    public float embarrasment = 50.0f;

    private float heatRateRate = 0.5f;

    public float heatRate = 3f;
    public float staminaRate = 1f;
    public float embarrasmentRate = -2f;

    private bool died = false;

    public SFX sfx;

    public randomEvent randomEventInstance;
    public StudioEventEmitter studioEventEmitter;

    [SerializeField] private Slider Slider1;
    [SerializeField] private Slider Slider2;
    [SerializeField] private Slider Slider3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        resetStatus();
    }

    // Update is called once per frame
    void Update()
    {

        budyHeat += heatRate * Time.deltaTime;
        stamina = Math.Min(100, stamina + staminaRate * Time.deltaTime);
        embarrasment = Math.Max(0, embarrasment + embarrasmentRate * Time.deltaTime);

        if (budyHeat > 100 || stamina < 0 || embarrasment > 100)
        {
            if (!died)
            {
                died = true;
                sfx.PlayDeath();
            }

            Debug.Log("you died");
        }

        heatRate += heatRateRate * Time.deltaTime;

        CheckAudioParameter();
        updateStatusUI();
    }



    public void button1Click() // Water
    {
        Debug.Log("Button 1 Clicked, Water");

        sfx.PlayDrink();

        budyHeat -= 10;
        stamina += 2;
        if (randomEventInstance.currentEvent == Event.None)
        {
            embarrasment += 2;
        }
    }

    public void button2Click() // Fanning
    {
        Debug.Log("Button 2 Clicked, Fanning");

        sfx.PlayFanning();

        budyHeat *= 0.9f;
        stamina -= 10;
        if (randomEventInstance.currentEvent == Event.None)
        {
            embarrasment += 10;
        }
    }

    public void button3Click() // 
    {
        Debug.Log("Button 3 Clicked");
        resetStatus();
    }

    private void resetStatus()
    {
        budyHeat = 30;
        stamina = 100;
        embarrasment = 0;
        died = false; 
    }

    private void updateStatusUI()
    {
        Slider1.value = budyHeat / 100;
        Slider2.value = stamina / 100;
        Slider3.value = embarrasment / 100;
    }

    void CheckAudioParameter()
    {
        studioEventEmitter.SetParameter("musicQuality", getMusicQuality());
        Debug.Log("[Audio] Music Quality: " + getMusicQuality());
    }

    private float getMusicQuality()
    {
        if (stamina <= 0 || budyHeat >= 100 || embarrasment >= 100)
        {
            return 0.0f;
        }
        else if (stamina < 33 || budyHeat > 66 || embarrasment > 66)
        {
            return 1.0f;
        }
        else if (stamina < 66 || budyHeat > 33 || embarrasment > 33)
        {
            return 2.0f;
        }
        else
        {
            return 3.0f;
        }
    }
}
