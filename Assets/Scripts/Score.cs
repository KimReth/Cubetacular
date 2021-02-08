using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player; //transform is responsible for position, rotation, scale
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
       scoreText.text = player.position.z.ToString("0"); //0 makes the display a whole number instead of a float
    }
}
