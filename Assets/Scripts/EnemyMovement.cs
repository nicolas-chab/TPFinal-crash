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
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > enemigoDer.transform.position.x - 1)
        {
            toRight = false;
           

        }
        if (transform.position.x < enemigoIzq.transform.position.x + 1)
        {
            toRight = true;

        }

    }
}