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
    private float event1chance = 0.05f;
    private float event2chance = 0.3f;

    private float defTime = 1.0f;
    private float time = 1.0f;

    public Event currentEvent = Event.None;

    public SFX sfx;



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
                time = defTime;
                return;
            }

            float randValue = Random.value;

            if (randValue < event1chance)
            {
                StartCoroutine((WaitEvent(Event.Clap, 5)));
            }
            else if (randValue < event1chance + event2chance)
            {
                StartCoroutine((WaitEvent(Event.Truck, 2)));
            }
            time = defTime;
        }
    }

    IEnumerator WaitEvent(Event eventType, float time)
    {
        currentEvent = eventType;

        switch (eventType)
        {
            case Event.Clap:
                sfx.PlayClap(); break;
            case Event.Truck:
                sfx.PlayTruck(); break;
        }

        Debug.Log(string.Format("Started Event {0} at timestamp : {1}", eventType, Time.time));

        yield return new WaitForSeconds(time);

        Debug.Log("Finished Event at timestamp : " + Time.time);
        currentEvent = Event.None;
    }
}