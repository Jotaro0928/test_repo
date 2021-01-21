using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearRank : MonoBehaviour
{
    private int score;
    private float time;
    private int timebonus;
    private int allscore;
    private Text rankText = null;
    // Start is called before the first frame update
    void Start()
    {
        rankText = GetComponent<Text>();
        score = GManager.instance.score;
        time = GManager.instance.time;
        if (time < 90) timebonus = 500;
        else
        {
            int t = (int)time;
            timebonus = 500 - (t - 90) * 5;
        }
        allscore = score + timebonus;
        if (GManager.instance != null)
        {
            if (allscore >=1000) rankText.text = "RANK : Perfect!!";
            else if (allscore > 900) rankText.text = "RANK : S";
            else if (allscore > 800) rankText.text = "RANK : A";
            else if (allscore > 700) rankText.text = "RANK : B";
            else if (allscore > 600) rankText.text = "RANK : C";
            else rankText.text = "RANK : D";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
