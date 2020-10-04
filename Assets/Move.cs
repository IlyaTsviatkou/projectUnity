using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float pos_X;
    float angle;
    SpriteRenderer rend;
    [SerializeField] float speed=0.2f;
    float a, b;
    // Start is called before the first frame update
    void Start()
    {
        a = Random.RandomRange(0, 2);
        if (a == 0)
            speed *= 1;
        if (a == 1)
            speed *= (-1);
        angle = Random.RandomRange(0, 360);
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rend.color.a == 1)
        {
           
            transform.position += new Vector3(speed*Time.deltaTime,speed*Time.deltaTime*Mathf.Cos(angle), 0);
        }
        if(transform.position.x <-3)
        {
            a = Random.RandomRange(0, 2);
            if (a == 0)
                speed *= 1;
            if (a == 1)
                speed *= (-1);
            angle = Random.RandomRange(0, 360);
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 3)
        {
            a = Random.RandomRange(0, 2);
            if (a == 0)
                speed *= 1;
            if (a == 1)
                speed *= (-1);
            angle = Random.RandomRange(0, 360);
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -5.12f)
        {
            a = Random.RandomRange(0, 2);
            if (a == 0)
                speed *= 1;
            if (a == 1)
                speed *= (-1);
            angle = Random.RandomRange(0, 360);
            transform.position = new Vector3(transform.position.x, 5.15f, transform.position.z);
        }
        if (transform.position.y > 4.17f)
        {
            a = Random.RandomRange(0, 2);
            if (a == 0)
                speed *= 1;
            if (a == 1)
                speed *= (-1);
            angle = Random.RandomRange(0, 360);
            transform.position = new Vector3(transform.position.x, -5.11f, transform.position.z);
        }
    }
}
