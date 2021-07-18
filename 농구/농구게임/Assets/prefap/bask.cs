using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bask : MonoBehaviour
{
    
    public float speed = 0.4f;
    public float speed1 = -0.4f;
    public float speed2 = 0.45f;
    public float speed3 = -0.45f;
    public float speed4 = 0.5f;
    public float speed5 = -0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 30 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 25)
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 25 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 20)
        {
            this.transform.Translate(0, speed1 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 20 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 18)
        {
            this.transform.Translate(0, speed3 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 18 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 11)
        {
            this.transform.Translate(0, speed2 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 11 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 10)
        {
            this.transform.Translate(0, speed5 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 10 && GameObject.Find("ScoreText").GetComponent<score>().time1 >= 6)
        {
            this.transform.Translate(0, speed5 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 <= 6 && GameObject.Find("ScoreText").GetComponent<score>().time1 > 00)
        {
            this.transform.Translate(0, speed4 * Time.deltaTime, 0);
        }
        if (GameObject.Find("ScoreText").GetComponent<score>().time1 == 0)
        {
            this.transform.position = new Vector3(-0.2978442f, 5.02f, -1.284047f);
        }
    }
}
