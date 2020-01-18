using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private PlayerController froggo;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("Player");
        if (gameControllerObject != null)
        {
            froggo = gameControllerObject.GetComponent<PlayerController>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
  
}
