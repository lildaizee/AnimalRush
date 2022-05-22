using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
