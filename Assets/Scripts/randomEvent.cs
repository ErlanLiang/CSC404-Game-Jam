using UnityEngine;
using System.Collections;

public class randomEvent : MonoBehaviour
{
    public float event1chance = 0.5f;
    public float event2chance = 0.8f;

    public float event1time = 3f;
    public float event2time = 10f;

    public float time = 15.0f;

    void Start()
    {

    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            float randValue = Random.value;
            float randValue2 = Random.value;

            if (randValue < event1chance)
            {
                StartCoroutine((WaitEvent(3)));
                time = 15.0f;
            }
            else if (randValue2 < event2chance)
            {
                StartCoroutine((WaitEvent(10)));
                time = 15.0f;
            }
            else
            {
                time = 15.0f;
            }
        }
    }

    IEnumerator WaitEvent(float time)
    {
        Debug.Log("Started Event at timestamp : " + Time.time);

        yield return new WaitForSeconds(time);

        Debug.Log("Finished Event at timestamp : " + Time.time);
    }
}