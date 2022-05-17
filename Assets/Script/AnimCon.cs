using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCon : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animator>().Play("Jogging");
    }

    void Update()
    {
        
    }
}
