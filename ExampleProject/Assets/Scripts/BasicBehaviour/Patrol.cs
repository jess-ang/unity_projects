using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [Range(3,7)]
    public int distance;
    [Range(3,10)]
    public float speed;
    private Vector3 startPos,endPos,targetPos;
    private void Awake()
    {
        startPos = transform.position; //Save the actual objects position
        endPos = startPos + transform.forward * distance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = Vector3.zero;
        if(Vector3.Distance(transform.position,startPos)<=0.1)
        {
            transform.LookAt(transform.position + Vector3.forward);
            targetPos = endPos;
        }
        if(Vector3.Distance(transform.position,endPos)<=0.1)
        {
            transform.LookAt(transform.position + Vector3.back);
            targetPos = startPos;
        }
        transform.position = Vector3.MoveTowards(transform.position,targetPos,speed*Time.deltaTime);
    }
}
