using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        Vector3 vector = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
            vector += Vector3.forward;
        if(Input.GetKey(KeyCode.A))
            vector += Vector3.left;
        if(Input.GetKey(KeyCode.S))
            vector += Vector3.back;
        if(Input.GetKey(KeyCode.D))
            vector += Vector3.right;
        
        if(vector!=Vector3.zero)
        {
            transform.LookAt(transform.position + vector);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            vector = Vector3.zero;
        }
    }


}
