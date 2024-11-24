using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void GotCollectable()
    {
        score++;        
    }
}
