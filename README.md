# Kogane Asset Database

AssetDatabase に関する処理をまとめたクラス

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // AssetDatabase.FindAssets で見つかった最初のアセットを取得
        var mySettings = KoganeAssetDatabase.LoadAsset<MySettings>();

        // 指定した GUID に紐づくアセットを取得
        var material = KoganeAssetDatabase.LoadAssetFromGUID<Material>( "2d0394f297d5f644d863ea5dc43359ad" );
    }
}
```