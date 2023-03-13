using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersInScene : MonoBehaviour
{
    [SerializeField] Color color;
    Transform[] chrs;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        chrs = GetComponentsInChildren<Transform>();
        if (chrs.Length > 0)
        {
            foreach (Transform person in chrs)
            {
                Gizmos.DrawSphere(person.position, .1f);
            }
        }
    }
}
