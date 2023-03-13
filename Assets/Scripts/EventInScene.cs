using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInScene : MonoBehaviour
{
    public EventData[] data;
    public EventData[] lastdata;
    [SerializeField] int time;

    void Start()
    {
        StartCoroutine(ticInSecond());
    }

    private void Update()
    {
        foreach (EventData d in data)
        {
            if (d.startTime == time)
            {
                Debug.Log(time);
                int sel = 0;
                foreach (GameObject g in d.ourObjects)
                {
                    if (g.GetComponent<Animator>() != null)
                    {
                        g.GetComponent<Animator>().runtimeAnimatorController = d.animation[sel];
                    }
                    else
                    {
                        g.AddComponent<Animator>().runtimeAnimatorController = d.animation[sel];
                    }
                    g.GetComponent<Animator>().Play(1);
                    sel++;
                }
            }
        }
    }

    IEnumerator ticInSecond()
    {
        yield return new WaitForSeconds(1);
        time++;
        StartCoroutine(ticInSecond());
    }
}
