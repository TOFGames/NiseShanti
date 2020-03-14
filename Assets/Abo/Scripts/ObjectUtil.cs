using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ObjectUtil {
    /// <summary>
    /// オブジェクト生成
    /// </summary>
    /// <param name="obj">生成したいオブジェクト</param>
    /// <returns>オブジェクト</returns>
    public static GameObject GenerateObject (Object obj) {
        return Object.Instantiate(obj) as GameObject;
    }

    /// <summary>
    /// オブジェクト生成
    /// </summary>
    /// <param name="obj">生成したいオブジェクト</param>
    /// <param name="pos">位置</param>
    /// <returns>オブジェクト</returns>
    public static GameObject GenerateObject (Object obj,Vector3 pos) {
        return Object.Instantiate(obj,pos,Quaternion.identity) as GameObject;
    }

    //=============================================================
    /// <summary>
    /// プレハブ生成
    /// </summary>
    /// <param name="path">リソースパス</param>
    /// <returns>オブジェクト</returns>
    public static GameObject GenerateResourcesPrefab (string path) {
        return Object.Instantiate(Resources.Load(path)) as GameObject;
    }

    /// <summary>
    /// プレハブ生成
    /// </summary>
    /// <param name="path">リソースパス</param>
    /// <param name="pos">位置</param>
    /// <returns></returns>
    public static GameObject GenerateResourcesPrefab (string path,Vector3 pos) {
        return Object.Instantiate(Resources.Load(path),pos,Quaternion.identity) as GameObject;
    }
}