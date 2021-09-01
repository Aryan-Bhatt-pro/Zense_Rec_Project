using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManage : MonoBehaviour
{
    public Text ScoreText;
    protected float score;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1*Time.deltaTime;
            //printf('%d', score);
            ScoreText.text = ((int)(score)).ToString();
        }
    }
}
