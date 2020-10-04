using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    float posX, posY;
    [SerializeField] GameObject[] vilage;
    [SerializeField] GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("vilage").Length<25)
        {
            posX = Random.RandomRange(-2.9f, 2.9f);
            posY = Random.RandomRange(-5f, 5f);
            Vector3 a = new Vector3(posX, posY, -1.67f);
            Instantiate(vilage[PlayerPrefs.GetInt("Scins")],a,Quaternion.identity);
        }
        if( GameObject.FindGameObjectsWithTag("bomb").Length<3)
        {
            posX = Random.RandomRange(-2.9f, 2.9f);
            posY = Random.RandomRange(-5f, 5f);
            Vector3 a = new Vector3(posX, posY, -1.67f);
            Instantiate(bomb, a, Quaternion.identity);
        }
    }
}
