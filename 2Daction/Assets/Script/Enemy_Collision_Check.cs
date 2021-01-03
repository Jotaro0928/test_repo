using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision_Check : MonoBehaviour
{
    /// <summary>
    /// 判定内に敵か壁がある
    /// </summary>
    [HideInInspector] public bool isOn = false;

    private string groundTag = "Ground";
    private string enemyTag = "Enemy";
    private string jumpStepTag = "JumpStep";
    private string hitAreaTag = "HitArea";

    #region//接触判定
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag || collision.tag == enemyTag || collision.tag == jumpStepTag || collision.tag == hitAreaTag)
        {
            isOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag || collision.tag == enemyTag || collision.tag == jumpStepTag || collision.tag == hitAreaTag)
        {
            isOn = false;
        }
    }
    #endregion
}
