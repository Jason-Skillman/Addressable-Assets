using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAsset : MonoBehaviour {

    public AssetReference assetRef;


    void Start() {
        Addressables.LoadAssetAsync<GameObject>(assetRef).Completed += (operation) => {
            Debug.Log("Loaded asset: " + operation.Result.name);
        };
    }

}
