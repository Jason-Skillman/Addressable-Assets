using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
//using UnityEditor.AddressableAssets.Settings;

public class DebugData : MonoBehaviour {

    void Start() {

    }

    void Update() {

        string buildPath = Addressables.BuildPath;
        Debug.Log("BuildPath: " + buildPath);

        string runtimePath = Addressables.RuntimePath;
        Debug.Log("RuntimePath: " + runtimePath);

        string playerBuildDataPath = Addressables.PlayerBuildDataPath;
        Debug.Log("PlayerBuildDataPath: " + playerBuildDataPath);

    }

    [ContextMenu("Build Player Content")]
    public void Build() {
        //Cant use in play mode
        //AddressableAssetSettings.BuildPlayerContent();
    }

}
