using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class TestManager : MonoBehaviour {
    //=============================================================


    //=============================================================
    private void Init () {
    }

    private void Awake () {
        Init();
    }

    private void Start () {
        AudioManager.Instance.PlayBGM("Ludere",true);
    }

    private void Update () {

    }
}