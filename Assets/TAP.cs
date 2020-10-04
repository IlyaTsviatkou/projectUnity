using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAP : MonoBehaviour
{
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        x = 1;
       // y = x;
        f=y=z = x;
        
        rend = GetComponent<SpriteRenderer>();
    }
    bool lose = false;
    float x, y, z,f;
        
    // Update is called once per frame
    void Update()
    {
        if(lose)
        {
           
            if (x < 2f)
            {
                Vector3 opa = new Vector3(x, y, z);
                transform.localScale = opa;
                if (f >= 0)
                {
                    Color b = new Color(rend.color.r, rend.color.g, rend.color.b, f);
                    rend.color = b;

                    f -= 0.01f;
                }
                x += 0.01f;
                y = x;
                z = x;
            }
        }
        if(rend.color.a<0.02f)
        {
            Destroy(gameObject);
        }
      //  Debug.Log(rend.color.a);      
    }
    private void OnMouseDown()
    {
        if (rend.color.a == 1)
        {
            HEALTH.quant++;
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, 10f);
            transform.position = pos;
            lose = true;
            float  a = Random.RandomRange(0, 4);
            if(a==0)
                rend.color = Color.yellow;
            if (a==1)
                rend.color = Color.blue;
            if (a==2)
                rend.color = Color.green;
            if (a == 3)
                rend.color = Color.red;

        }
    }
    private void OnMouseEnter()
    {

       
       // rend.color = Color.green;
    }
    private void OnMouseUp()
    {
       // rend.color = Color.white;
    }
}
