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
        if (collision.gameObject.tag == "Player" )
        {
            rb.AddForceAtPosition(collision.gameObject.transform.forward * 1000f,collision.GetContact(1).point,ForceMode.Impulse);
            //Destroy(this.gameObject);
        }
    }
}
