using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class HeadData : MonoBehaviour
{
    GameObject Agent_parent; // 親オブジェクト
    Transform Agent_head; // 子オブジェクト
    GameObject Player_parent; // 親オブジェクト
    Transform Player_head; // 子オブジェクト
    StreamWriter sw;
    FileInfo fi;

    void Start()
    {
        // Agentという名の親オブジェクトを検索
        Agent_parent = GameObject.Find("Agent");
        //headオブジェクトを検索
        Agent_head = (((((Agent_parent.transform.GetChild(1)).transform.GetChild(2)).transform.GetChild(0)).transform.GetChild(0)).transform.GetChild(1)).transform.GetChild(0);

        // Playerという名の親オブジェクトを検索
        Player_parent = GameObject.Find("Player");
        //headオブジェクトを検索
        Player_head = ((((((Player_parent.transform.GetChild(1)).transform.GetChild(0)).transform.GetChild(2)).transform.GetChild(0)).transform.GetChild(0)).transform.GetChild(1)).transform.GetChild(0);


        string[] header = { "Frame", "Agent_y", "Player_y" };
        DateTime now = DateTime.Now;
        string date = now.ToString("yyyy_MM_dd_HH-mm-ss");

        fi = new FileInfo(Application.dataPath + "/Data/" + date + ".csv");
    }

    // Update is called once per frame
    void Update()
    {
        sw = fi.AppendText();
        sw.WriteLine($"{Time.frameCount},{Agent_head.transform.position.y},{Player_head.transform.position.y},{Time.deltaTime}");
        sw.Flush();
        sw.Close();
    }
}
