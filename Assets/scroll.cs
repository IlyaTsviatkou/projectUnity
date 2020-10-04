using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    Renderer renderer;
    [SerializeField] float speed = 0.008f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    float x = 0;
    // Update is called once per frame
    void Update()
    {

        Vector2 offset = new Vector2(x, 0);
        x += speed;
        renderer.material.mainTextureOffset = offset;
    }
}
