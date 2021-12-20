using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticlmovment : MonoBehaviour
{
    public float movespeed = 1.0f;


    void FixedUpdate()
    {
    transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - movespeed, transform.position.y), 0.1f);
    }
}
