using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FRUIT : MonoBehaviour
{
    public AudioManager miAm;
    private Playerlives lifeSystem;
    int coincount=0;
    public Text Coincounter;
    // Start is called before the first frame update
    void Start()
    {
        
        lifeSystem = FindObjectOfType<Playerlives>();
    }

   
    // Update is called once per frame
    void Update()
    {
        Coincounter.text = "" + coincount;
        if (coincount == 4)
        {
            lifeSystem.GiveLife();
            coincount = 0;
            
        }
    }
    public void OnTriggerEnter(Collider col)
    {

       
        if (col.gameObject.tag == "Fruit")
        {
            
            coincount = coincount + 1;
            col.gameObject.SetActive(false);
            miAm.PlayClipFruit();
        }
    }
}
