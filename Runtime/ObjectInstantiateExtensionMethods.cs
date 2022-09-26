using UnityEngine;

namespace Kogane
{
    public static class ObjectInstantiateExtensionMethods
    {
        public static T Instantiate<T>( this T self ) where T : Object
        {
            return Object.Instantiate( self );
        }

        public static T Instantiate<T>
        (
            this T  self,
            Vector3 position
        ) where T : Object
        {
            return Object.Instantiate
            (
                original: self,
                position: position,
                rotation: Quaternion.identity
            );
        }

        public static T Instantiate<T>
        (
            this T     self,
            Vector3    position,
            Quaternion rotation
        ) where T : Object
        {
            return Object.Instantiate
            (
                original: self,
                position: position,
                rotation: rotation
            );
        }

        public static T Instantiate<T>
        (
            this T     self,
            Vector3    position,
            Quaternion rotation,
            Transform  parent
        ) where T : Object
        {
            return Object.Instantiate
            (
                original: self,
                position: position,
                rotation: rotation,
                parent: parent
            );
        }

        public static T Instantiate<T>
        (
            this T    self,
            Transform parent
        ) where T : Object
        {
            return Object.Instantiate
            (
                original: self,
                parent: parent
            );
        }

        public static T Instantiate<T>
        (
            this T    self,
            Transform parent,
            bool      worldPositionStays
        ) where T : Object
        {
            return Object.Instantiate
            (
                original: self,
                parent: parent,
                worldPositionStays: worldPositionStays
            );
        }
    }
}