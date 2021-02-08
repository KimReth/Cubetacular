using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    
    void FixedUpdate()  //Unity likes fixedupdate when dealing with physics, Update is called once per frame, not good for jumping
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //This expression at the end adds a force dependent on the user's frame rate

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //fourth parameter is force!
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
