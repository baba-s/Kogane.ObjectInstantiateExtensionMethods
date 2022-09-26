# Kogane Object Instantiate Extension Methods

Object.Instantiate の拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    public GameObject m_prefab;

    private void Awake()
    {
        var r1 = m_prefab.Instantiate();
        var r2 = m_prefab.Instantiate( Vector3.zero );
        var r3 = m_prefab.Instantiate( Vector3.zero, Quaternion.identity );
        var r4 = m_prefab.Instantiate( Vector3.zero, Quaternion.identity, transform );
        var r5 = m_prefab.Instantiate( transform );
        var r6 = m_prefab.Instantiate( transform, true );
    }
}
```