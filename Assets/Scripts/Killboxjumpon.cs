using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killboxjumpon : MonoBehaviour
{
    public GameObject fruit;
    public AudioManager miAm;
    public GameObject enemyWhoDies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            for(int i = 0;i<5; i++)
            {
                Destroy(enemyWhoDies);
                miAm.PlayClipBox();
                fruit.SetActive(true);
               
                Instantiate(fruit);
            }
            
        }
    }
}
