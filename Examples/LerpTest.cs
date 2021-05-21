using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    [SerializeField]
    GameObject go;


    private void Start()
    {
        Lerper.MoveTo(go, new Vector3(10, 10, 10));
        Lerper.MoveTo(go, new Vector3(-10, 20, 10));
        Lerper.RotateTo(go, 950);
    }
}
