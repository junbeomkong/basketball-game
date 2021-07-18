using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public int cnt1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.Find("ScoreText").GetComponent<score>().time1 > 30)
        {
            cnt1 += 2;
        }
        else
        {
            cnt1 += 3;
        }
    }
}
