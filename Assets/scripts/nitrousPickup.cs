using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collectable : MonoBehaviour
{
    // The game play script
    GameManager gp;
    private void Start()
    {
        gp = GameObject.Find("GamePlay").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        gp.GotCollectable();

        Destroy(this.gameObject);
    }
}
