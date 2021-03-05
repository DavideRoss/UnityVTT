using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public string Name;
    public bool IsEntrance;

    MeshRenderer _mr;

    private void Awake() {
        _mr = GetComponent<MeshRenderer>();
    }

    public void SetVisibility(bool visibility)
    {
        _mr.enabled = visibility;
    }
}
