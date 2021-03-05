using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Link : MonoBehaviour
{
    public KeyCode Key;

    public Gateway GatewayA;
    public Gateway GatewayB;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(Key))
        {
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawGizmos();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        DrawGizmos();
    }

    private void DrawGizmos()
    {
        if (GatewayA == null || GatewayB == null) return;
        Handles.Label((GatewayA.transform.position + GatewayB.transform.position) / 2, Key.ToString());
        Gizmos.DrawLine(GatewayA.transform.position, GatewayB.transform.position);
    }
}
