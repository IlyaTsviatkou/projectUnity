using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HEALTH : MonoBehaviour
{
    static public int health;
    static public int quant;
    static public float time;
   [SerializeField] Text TScore;
    [SerializeField] Text Ttime;
    [SerializeField] Text TBPM;
    [SerializeField] Image[] TImage;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        quant = 0;
        health = 3;
    }
    float bpm;
    float a;
    // Update is called once per frame
    void Update()
    {
        if(health==2)
        {
            TImage[2].enabled = false;
        }
        if (health == 1)
        {
            TImage[1].enabled = false;
        }
        time += 1 * Time.deltaTime;
        bpm = quant / time;
        time = (float)((int)(time * 100)) / 100;
        bpm = (float)((int)(bpm * 100)) / 100;
        if (bpm > PlayerPrefs.GetFloat("MAXBPM"))
            PlayerPrefs.SetFloat("MAXBPM", bpm);
        TScore.text = "Score: " + quant;
        TBPM.text = "BPM: " + bpm;
        Ttime.text = "Time: " + time;
        if(health==0)
        {
            if (quant > PlayerPrefs.GetFloat("MAXSCORE"))
                PlayerPrefs.SetFloat("MAXSCORE", quant);
            if (time > PlayerPrefs.GetFloat("MAXTIME"))
                PlayerPrefs.SetFloat("MAXTIME", time);
            
            TImage[0].enabled = false;
            Application.LoadLevel(0);
        }
    }
}
