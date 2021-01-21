using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timeText = null;
    //private float oldTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            timeText.text = "Time: " + GManager.instance.time;
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
        //　クリア化ゲームオーバーになっていなければ時間を計測
        if (!GManager.instance.isStageClear && !GManager.instance.isGameOver)
        {
            //oldTime += Time.deltaTime;
            GManager.instance.time += Time.deltaTime;
            timeText.text = "Time:" + GManager.instance.time.ToString("0.0");
        }
    }
}
