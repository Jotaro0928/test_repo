using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
    private Text timeText = null;
    private float time = 0;
    private int timebonus = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = GManager.instance.time;
        if (time < 90) timebonus = 500;
        else
        {
            int t = (int)time;
            timebonus = 500 - (t - 90) * 5;
        }
        timeText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            timeText.text = "Time: " + GManager.instance.time.ToString("0.0")+" Time Bonus:"+timebonus;
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
