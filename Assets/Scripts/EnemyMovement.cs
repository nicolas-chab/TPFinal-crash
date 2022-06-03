using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool toRight;

    public GameObject enemigoIzq;
    public GameObject enemigoDer;

   

    int yOffset;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
        yOffset = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(0, 0, speed);
        }
        else
        {
            transform.position -= new Vector3(0, 0, speed);
        }

        if (transform.position.z > enemigoDer.transform.position.z - 1)
        {
            toRight = false;
           

        }
        if (transform.position.z < enemigoIzq.transform.position.z + 1)
        {
            toRight = true;

        }

    }
}