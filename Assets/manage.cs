using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manage : MonoBehaviour
{
    [SerializeField] Text[] T;
    [SerializeField] Image[] Scins;
    int a ;
    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetInt("Scins");
        for(int i=0;i<3;i++)
        {
            Scins[i].enabled=false;
        }
        Scins[PlayerPrefs.GetInt("Scins")].enabled = true;
        T[0].text = "MAXSCORE: " + PlayerPrefs.GetFloat("MAXSCORE");
        T[1].text = "MAXTIME: " + PlayerPrefs.GetFloat("MAXTIME");
        T[2].text = "MAXBPM: " + PlayerPrefs.GetFloat("MAXBPM");
    }
    
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Scins", a);
    }
    public void LOAD()
    {
        Application.LoadLevel(1);
    }
    public void MENU()
    {
        Application.LoadLevel(0);
    }
    public void right()
    {
        Scins[a].enabled = false;
        if(a==2)
        {
            a = 0;

        }
        else
        {
            a++;
        }
        Scins[a].enabled = true;
    }
    public void left()
    {
        Scins[a].enabled = false;
        if (a==0)
        {
            a = 2;
        }
        else { a--; }
        Scins[a].enabled = true;
    }
}
