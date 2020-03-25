using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SelfDestruct : MonoBehaviour {

	public float lifetime = 3f;

	void Start() {
		Invoke("Release", lifetime);
	}

	void Release() {
		if(!Addressables.ReleaseInstance(gameObject))
			Destroy(gameObject);
	}
}