using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
public class KillPlayer : MonoBehaviour
{
     public Transform Player;
     public Transform RespawnPoint;
    public AudioManager miAm;
    private Playerlives lifeSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        lifeSystem = FindObjectOfType<Playerlives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            lifeSystem.TakeLife();
            miAm.PlayClipEnemy();
            Player.transform.position = RespawnPoint.transform.position;
        }
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Enemy")
        {
            lifeSystem.TakeLife();
            miAm.PlayClip();
            Player.transform.position = RespawnPoint.transform.position;
            
           
        }

    }
}
