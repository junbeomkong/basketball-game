using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    TextMesh closer;
    // Start is called before the first frame update
    void Start()
    {
        closer = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 0)
        {
            closer.text = "GAME OVER\nSCORE " + GameObject.Find("touch").GetComponent<touch>().cnt1.ToString();
            
        }
    }
}
