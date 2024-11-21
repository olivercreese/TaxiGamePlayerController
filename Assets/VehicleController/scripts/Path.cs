using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Path : MonoBehaviour
{
    public Color linecolor;

    private List<Transform> nodes = new List<Transform>();

    private void OnDrawGizmos()
    {
        Gizmos.color = linecolor;

        Transform[] pathTransforms = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

        for (int i = 0; i < nodes.Count; i++)
        {
            Vector3 currentNode = nodes[i].position;
        }

        int count = nodes.Count;
        for (int i = 0; i < count; i++)
        {
            Vector3 currentNode = nodes[i].position;
            Vector3 previousNode = nodes[(count - 1 + i) % count].position;
            Gizmos.DrawLine(previousNode, currentNode);
            Gizmos.DrawSphere(currentNode, 1);
        }
    }
}
