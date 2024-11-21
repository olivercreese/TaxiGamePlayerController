using UnityEngine;

public class collisionScript : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            rb.AddForce(collision.gameObject.transform.forward * 500f,ForceMode.Impulse);
            Debug.Log("Collision with player");
            //Destroy(this.gameObject);
        }
    }
}
