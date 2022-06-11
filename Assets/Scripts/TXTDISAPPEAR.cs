using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TXTDISAPPEAR : MonoBehaviour
{
    private float timefortxtdisappearence;
    // Start is called before the first frame update
    void Start()
    {
        timefortxtdisappearence = 4;
    }

    // Update is called once per frame
    void Update()
    {
        timefortxtdisappearence -= Time.deltaTime;
        if (timefortxtdisappearence < 0)
        {
            Destroy(gameObject);
        }
    }
}
