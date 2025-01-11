using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{   
    public float budyHeat = 50.0f;
    public float stamina = 50.0f;
    public float embarrasment = 50.0f;

    [SerializeField] private Slider Slider1;
    [SerializeField] private Slider Slider2;
    [SerializeField] private Slider Slider3;

    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateStatusUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        updateStatusUI();
    }

    public void button1Click() //water
    {
        budyHeat -= 10;
        stamina -= 10;
        embarrasment -= 10;
    }

    public void button2Click() //f
    {
        budyHeat += 10;
        stamina += 10;
        embarrasment -= 10;
    }

    public void button3Click() 
    {
        budyHeat -= 10;
        stamina += 10;
        embarrasment += 10;
    }

    private void updateStatusUI()
    {
        Slider1.value = budyHeat / 100;
        Slider2.value = stamina / 100;
        Slider3.value = embarrasment / 100;
    }
}
