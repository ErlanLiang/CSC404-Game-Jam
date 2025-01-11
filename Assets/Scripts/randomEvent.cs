using UnityEngine;
using System.Collections;
using static Unity.VisualScripting.FlowStateWidget;


public enum Event
{
    None,
    Clap,
    Truck
}

public class randomEvent : MonoBehaviour
{
    public float event1chance = 0.5f;
    public float event2chance = 0.8f;

    public float event1time = 3f;
    public float event2time = 10f;

    public float time = 15.0f;

    public Event currentEvent = Event.None;



    void Start()
    {

    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            if (currentEvent != Event.None)
            {
                time = 15.0f;
                return;
            }

            float randValue = Random.value;
            float randValue2 = Random.value;

            if (randValue < event1chance)
            {
                StartCoroutine((WaitEvent(Event.Clap, 3)));
                time = 15.0f;
            }
            else if (randValue2 < event2chance)
            {
                StartCoroutine((WaitEvent(Event.Truck, 10)));
                time = 15.0f;
            }
            else
            {
                time = 15.0f;
            }
        }
    }

    IEnumerator WaitEvent(Event eventType, float time)
    {
        currentEvent = eventType;
        Debug.Log(string.Format("Started Event {0} at timestamp : {1}", eventType, Time.time));

        yield return new WaitForSeconds(time);

        Debug.Log("Finished Event at timestamp : " + Time.time);
        currentEvent = Event.None;
    }
}