using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object


    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        StartCoroutine(ExecuteAfterTime(2));
        IEnumerator ExecuteAfterTime(float time)
        {

            yield return new WaitForSeconds(time);

            player.SetActive(true);
        }
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
        
    }
}
