using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Killable : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        health -= 2;
        if(health<=0)
            Destroy(gameObject);   
    }
}
