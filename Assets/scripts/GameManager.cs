using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

   
    public void GotCollectable()
    {
        player.GetComponent<TrafficController>().nitrous += 100;
    }
}
