using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class SceneAddLoader : MonoBehaviour {

    public AssetReference sceneAssetRef;


    void Start() {
        
    }

    void Update() {

    }

    [ContextMenu("LoadScene")]
    public void LoadScene() {
        sceneAssetRef.LoadSceneAsync(LoadSceneMode.Additive).Completed += (operation) => {
            if(operation.Status != AsyncOperationStatus.Succeeded) {
                Debug.Log("Failed");
                return;
            }

            Debug.Log("Loaded scene: " + operation.Result.Scene.name);
        };
    }

    [ContextMenu("UnloadScene")]
    public void UnloadScene() {
        sceneAssetRef.UnLoadScene().Completed += (operation) => {
            if(operation.Status != AsyncOperationStatus.Succeeded) {
                Debug.Log("Failed");
                return;
            }

            Debug.Log("Unloaded scene: " + operation.Result.Scene.name);
        };

    }

}
