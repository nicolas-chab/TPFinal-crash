using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public bool forward;   
    public GameObject positionPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (forward == true)
        {
            transform.position += new Vector3(0, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(0, 0, 0);
        }

        if (transform.position.x > positionPlayer.transform.position.x +4.5)
        {
            transform.position += new Vector3(0+1, 0, 0);


        }
        if (transform.position.x < positionPlayer.transform.position.x -4.5)
        {
            forward = true;

        }
    }
}
