using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

}
