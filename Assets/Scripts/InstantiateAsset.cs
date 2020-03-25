using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class InstantiateAsset : MonoBehaviour {

    public AssetReference assetRef;


    void Start() {
        Addressables.InstantiateAsync(assetRef, Vector3.zero, Quaternion.identity).Completed += (operation) => {
            Debug.Log("Instatiated asset: " + operation.Result.name);
        };
    }

}
