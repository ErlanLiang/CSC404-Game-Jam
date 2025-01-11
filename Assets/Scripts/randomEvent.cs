using UnityEngine;

public class randomEvent : MonoBehaviour
{
    public float event1chance = 0.5f;
    public float event2chance = 0.1f;

    public float time = 1.0f;

    void Start()
    {

    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            time = 1.0f;
            float randValue = Random.value;
            float randValue2 = Random.value;

            if (randValue < event2chance)
            {
                Debug.Log("Event 2 happens");
            }
            else if (randValue2 < event1chance)
            {
                Debug.Log("Event 1 happens");
            }
        }
    }
}