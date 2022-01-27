using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWithChildName : MonoBehaviour
{
    [AutoChildren("Test")] private BoxCollider _boxColiider;

    private void Start()
    {
        Debug.Log(_boxColiider.gameObject.name);
    }
}
