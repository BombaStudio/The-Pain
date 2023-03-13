using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventData
{
    public GameObject[] ourObjects;
    public RuntimeAnimatorController[] animation;
    public int startTime;
    public bool animationCut;
}
