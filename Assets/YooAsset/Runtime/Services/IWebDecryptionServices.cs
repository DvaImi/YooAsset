using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YooAsset
{
    public interface IWebDecryptionServices
    {
        AssetBundle LoadAssetBundle(byte[] fileData);
    }
}