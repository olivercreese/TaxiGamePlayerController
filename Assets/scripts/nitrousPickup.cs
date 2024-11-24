using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using NUnit.Framework;


public class Collectable : MonoBehaviour
{
    public Transform Path;
    private List<Transform> nodes;
    GameManager gp;
    int rand;
    private void Start()
    {

        gp = GameObject.Find("GamePlay").GetComponent<GameManager>();

        Transform[] pathTransforms = Path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();
        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != Path.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

       rand = Random.Range(0, nodes.Count);

        transform.position = nodes[rand].position;
    }
    private void OnTriggerEnter(Collider other)
    {
        gp.GotCollectable();
        rand = Random.Range(0, nodes.Count);
        transform.position = nodes[rand].position;
    }
}
