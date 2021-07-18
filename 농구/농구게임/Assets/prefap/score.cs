using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    
    private float time= 60.0f;
    public int time1 = 1;
    TextMesh scoreText;
    GameObject gg = null;
    GameObject gg1 = null;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMesh>();
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        time1 = (int)time;
        if (time1 > 0)
        {
       
            scoreText.text = time1.ToString() + "      " + GameObject.Find("touch").GetComponent<touch>().cnt1.ToString();
        }
        if(time1 == 0)
        {
            gg = GameObject.Find("Text");
            gg1 = GameObject.Find("Close");
            Destroy(gg);
            Destroy(scoreText);
            
            
        }
    }
   
}
