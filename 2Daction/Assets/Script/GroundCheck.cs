﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [Header("エフェクトがついた床を判定するか")] public bool checkPlatformGroud = true;

    private string groundTag = "Ground";//地面
    private string platformTag = "GroundPlatform";//すり抜ける床
    private string moveFloorTag = "MoveFloor";//動く床
    private string fallFloorTag = "FallFloor";//落下する床
    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;

    //接地判定を返すメソッド
    //物理判定の更新毎に呼ぶ必要がある
    public bool IsGround()
    {
        if (isGroundEnter || isGroundStay)
        {
            isGround = true;
        }
        else if (isGroundExit)
        {
            isGround = false;
        }

        isGroundEnter = false;
        isGroundStay = false;
        isGroundExit = false;
        return isGround;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundEnter = true;
        }
        else if (checkPlatformGroud && (collision.tag == platformTag || collision.tag == moveFloorTag || collision.tag == fallFloorTag))
        {
            isGroundEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundStay = true;
        }
        else if (checkPlatformGroud && (collision.tag == platformTag || collision.tag == moveFloorTag || collision.tag == fallFloorTag))
        {
            isGroundStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundExit = true;
        }
        else if (checkPlatformGroud && (collision.tag == platformTag || collision.tag == moveFloorTag || collision.tag == fallFloorTag))
        {
            isGroundExit = true;
        }
    }
}
