using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Playerlives : MonoBehaviour
{
    public GameObject Player;
    public int startingLives;
    private int lifeCounter;
    private Text text;
    public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent <Text>();
        lifeCounter = startingLives;

    }

    // Update is called once per frame
    void Update()
    {

        text.text = ""+lifeCounter;
        if (lifeCounter < 0)
        {
            Destroy(Player);
            SceneManager.LoadScene("Game_over");
        }
    }
    public void GiveLife()
    {
        lifeCounter++;
    }

    public void TakeLife()
    {
        lifeCounter--;
    }
}
