
using UnityEngine;

public class playerCollide : MonoBehaviour
{
    public playerMove movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //this should display info for whatever the player collides with
        {
            movement.enabled = false;  //If the object (player) collides with obstacle, player movement is ceased
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
