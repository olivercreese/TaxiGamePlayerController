using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Passenger : MonoBehaviour
{
    public Transform Path;
    private List<Transform> nodes;
   
    GameManager gp;
    public GameObject player;
    public GameObject[] enemy;
    bool withsomeone=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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

        int rand = Random.Range(0, nodes.Count);

        transform.position = nodes[rand].position;
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Taxi");
        int numberofenemy = enemy.Length;
        
    }

    private void OnTriggerEnter(Collider other)
    { 
        //register the taxi that hit you
        withsomeone = true; 
        gp.GotCollectable();
    }

    private void Update()
    {
        if(withsomeone)
        {
            //follow the taxi
        }
    }
}
