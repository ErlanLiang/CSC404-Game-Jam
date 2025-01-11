using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{   
    public float budyHeat = 50.0f;
    public float stamina = 50.0f;
    public float embarrasment = 50.0f;

    public float heatRate = 1f;
    public float staminaRate = 1f;

    [SerializeField] private Slider Slider1;
    [SerializeField] private Slider Slider2;
    [SerializeField] private Slider Slider3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateStatusUI();
    }

    // Update is called once per frame
    void Update()
    {
        budyHeat += heatRate * Time.deltaTime;
        stamina += staminaRate * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        updateStatusUI();
    }

    public void button1Click() // Water
    {
        Debug.Log("Button 1 Clicked, Water");
        budyHeat -= 10;
        stamina += 2;
        embarrasment += 2;
    }

    public void button2Click() // Fanning
    {
        Debug.Log("Button 2 Clicked, Fanning");
        budyHeat += 10;
        stamina -= 10;
        embarrasment += 10;
    }

    public void button3Click() // 
    {
        Debug.Log("Button 3 Clicked");
        budyHeat = 100;
        stamina = 100;
        embarrasment = 100;
    }

    private void updateStatusUI()
    {
        Slider1.value = budyHeat / 100;
        Slider2.value = stamina / 100;
        Slider3.value = embarrasment / 100;
    }
}
