using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityExtensions
{
    public static bool Contains(this LayerMask mask, GameObject go)=> (1 << go.layer & mask) > 0;
    public static bool Contains(this LayerMask mask, Component comp)=> (1 << comp.gameObject.layer & mask) > 0;
}
