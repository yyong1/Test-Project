using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float yminPosition = -300f;


    // Update is called once per frame 
    void Update()
    {
        if (transform.position.y < yminPosition)
            Destroy(gameObject);
    }
}