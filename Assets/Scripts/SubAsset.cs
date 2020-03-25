using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SubAsset : MonoBehaviour {

    public AssetReference assetRef;
    //public Mesh mesh;


    void Start() {
        assetRef.LoadAssetAsync<GameObject>().Completed += (operation) => {
            Addressables.LoadAssetAsync<Mesh>("FancyBowl[Sphere001]").Completed += (operation2) => {
                Debug.Log("Loaded subasset: " + operation2.Result.name);
            };

        };
    }

}
