using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Kogane
{
    public static class KoganeAssetDatabase
    {
        public static T LoadAsset<T>() where T : Object
        {
            var guid = AssetDatabase
                    .FindAssets( $"t:{typeof( T ).Name}" )
                    .FirstOrDefault()
                ;

            if ( string.IsNullOrEmpty( guid ) ) return null;

            var assetPath = AssetDatabase.GUIDToAssetPath( guid );
            var asset     = AssetDatabase.LoadAssetAtPath<T>( assetPath );

            return asset;
        }
    }
}