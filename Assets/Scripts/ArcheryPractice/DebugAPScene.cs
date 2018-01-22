﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugAPScene : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Debug Save SaveData");
            DataManager.Instance.SaveData();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Debug Create SaveData");
            DataManager.Instance.data = GameSaveData.Create();
            DataManager.Instance.SaveData();
        }


    }

}

