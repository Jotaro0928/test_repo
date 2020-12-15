using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    [Header("フェード")] public FadeImage fade;
    private bool firstPush = false;
    private bool goNextScene = false;
    //スタート」ボタンを押されたら呼ばれる
    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            Debug.Log("Go Next Scene!");
            fade.StartFadeOut();
            firstPush = true;
        }
    }
    private void Update()
    {
        if (!goNextScene && fade.IsFadeOutComplete())
        {
            SceneManager.LoadScene("Stage1");
            goNextScene = true;
        }
    }

}
