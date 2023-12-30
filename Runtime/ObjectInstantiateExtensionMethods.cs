using System.Collections.Generic;
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

        public static T Instantiate<T>
        (
            this T     self,
            Vector3    position,
            Quaternion rotation,
            GameObject parent
        ) where T : Object
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

        public static T Instantiate<T>
        (
            this T     self,
            GameObject parent
        ) where T : Object
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

        public static T Instantiate<T>
        (
            this T     self,
            GameObject parent,
            bool       worldPositionStays
        ) where T : Object
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

        public static GameObject[] InstantiatesFromSceneObject
        (
            this GameObject self,
            int             count
        )
        {
            self.SetActive( true );
            var result = self.Instantiates( count, self.transform.parent );
            self.SetActive( false );
            return result;
        }

        public static T InstantiateFromSceneObject<T>( this T self ) where T : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiate( self.transform.parent );
            gameObject.SetActive( false );
            return result;
        }

        public static T InstantiateFromSceneObject<T>
        (
            this T  self,
            Vector3 position
        ) where T : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiate( position, Quaternion.identity, self.transform.parent );
            gameObject.SetActive( false );
            return result;
        }

        public static T InstantiateFromSceneObject<T>
        (
            this T     self,
            Vector3    position,
            Quaternion rotation
        ) where T : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiate( position, rotation, self.transform.parent );
            gameObject.SetActive( false );
            return result;
        }

        public static T[] InstantiatesFromSceneObject<T>
        (
            this T self,
            int    count
        ) where T : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiates( count, self.transform.parent );
            gameObject.SetActive( false );
            return result;
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

        public static T[] Instantiates<T, TParent>
        (
            this T                 self,
            int                    count,
            IReadOnlyList<TParent> parentArray
        ) where T : Object where TParent : Component
        {
            var array = new T[ count ];

            for ( var i = 0; i < count; i++ )
            {
                array[ i ] = Object.Instantiate( self, parentArray[ i ].transform );
            }

            return array;
        }

        public static GameObject[] InstantiatesFromSceneObject<TParent>
        (
            this GameObject self,
            int             count,
            TParent         parent
        ) where TParent : Component
        {
            self.SetActive( true );
            var result = self.Instantiates( count, parent );
            self.SetActive( false );
            return result;
        }

        public static T[] InstantiatesFromSceneObject<T, TParent>
        (
            this T  self,
            int     count,
            TParent parent
        ) where T : Component where TParent : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiates( count, parent );
            gameObject.SetActive( false );
            return result;
        }

        public static T[] InstantiatesFromSceneObject<T, TParent>
        (
            this T                 self,
            int                    count,
            IReadOnlyList<TParent> parentArray
        ) where T : Component where TParent : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiates( count, parentArray );
            gameObject.SetActive( false );
            return result;
        }

        public static T[] Instantiates<T>
        (
            this T     self,
            int        count,
            GameObject parent
        ) where T : Object
        {
            var array = new T[ count ];

            for ( var i = 0; i < count; i++ )
            {
                array[ i ] = Object.Instantiate( self, parent.transform );
            }

            return array;
        }

        public static GameObject[] InstantiatesFromSceneObject<T>
        (
            this GameObject self,
            int             count,
            GameObject      parent
        )
        {
            self.SetActive( true );
            var result = self.Instantiates( count, parent );
            self.SetActive( false );
            return result;
        }

        public static T[] InstantiatesFromSceneObject<T>
        (
            this T     self,
            int        count,
            GameObject parent
        ) where T : Component
        {
            var gameObject = self.gameObject;
            gameObject.SetActive( true );
            var result = self.Instantiates( count, parent );
            gameObject.SetActive( false );
            return result;
        }
    }
}