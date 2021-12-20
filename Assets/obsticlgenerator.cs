using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticlgenerator : MonoBehaviour
{
    public GameObject pipprefab;
    public int genrtionrate = 100;

    private int timer = 100;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if(timer >=genrtionrate)
        {
            timer = 0;
            GameObject newobsticle = Instantiate(pipprefab, new Vector2(transform.position.x,
                transform.position.y + Random.Range(-2.0f, 2.0f)),pipprefab.transform.rotation);
            Destroy(newobsticle, 5f);
        }
    }
}
