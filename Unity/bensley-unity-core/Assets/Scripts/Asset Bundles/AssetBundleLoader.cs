using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class AssetBundleLoader : MonoBehaviour
{
    string assetBundlePath = Application.streamingAssetsPath + "/AssetBundles/Bundles/bensleyimages";
    public void Setup()
    {
        //assetBundlePath.
        Debug.Log("We Here Setup() AssetBundleLoader "+ assetBundlePath);
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(assetBundlePath);
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("MyObject");
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
