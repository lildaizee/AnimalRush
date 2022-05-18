using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCon : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animator>().Play("Fox_Run_InPlace");
    }

    void Update()
    {
        
    }
}
