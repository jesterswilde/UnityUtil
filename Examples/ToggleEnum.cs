using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Slapping System.Flags onto an enum will have it behave like layer masks in the inspector. 
/// Because enums are just a single value, I suggest using powers of 2 for the enum values
/// </summary>
public class ToggleEnum : MonoBehaviour
{
    [SerializeField]
    Things thing; 
}

[System.Flags]
public enum Things
{
    Thing = 1 << 0, 
    Foo = 1 << 1,
    Bar = 1 << 2,
}
