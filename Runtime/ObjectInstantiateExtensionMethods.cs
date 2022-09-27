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

        public static T Instantiate<T, TParent>
        (
            this T     self,
            Vector3    position,
            Quaternion rotation,
            TParent    parent
        ) where T : Object where TParent : Component
        {
            return Object.Instantiate
            (
                original: self,
                position: position,
                rotation: rotation,
                parent: parent.transform
            );
        }

        public static T Instantiate<T, TParent>
        (
            this T  self,
            TParent parent
        ) where T : Object where TParent : Component
        {
            return Object.Instantiate
            (
                original: self,
                parent: parent.transform
            );
        }

        public static T Instantiate<T, TParent>
        (
            this T  self,
            TParent parent,
            bool    worldPositionStays
        ) where T : Object where TParent : Component
        {
            return Object.Instantiate
            (
                original: self,
                parent: parent.transform,
                worldPositionStays: worldPositionStays
            );
        }

        public static T[] Instantiates<T>( this T self, int count ) where T : Object
        {
            var array = new T[ count ];

            for ( var i = 0; i < count; i++ )
            {
                array[ i ] = Object.Instantiate( self );
            }

            return array;
        }

        public static T[] Instantiates<T, TParent>
        (
            this T  self,
            int     count,
            TParent parent
        ) where T : Object where TParent : Component
        {
            var array = new T[ count ];

            for ( var i = 0; i < count; i++ )
            {
                array[ i ] = Object.Instantiate( self, parent.transform );
            }

            return array;
        }
    }
}