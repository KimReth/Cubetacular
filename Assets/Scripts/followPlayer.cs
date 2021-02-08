
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; //variable to move position of camera in relation to the current object

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;  //refers to transform of current object
    }
}
