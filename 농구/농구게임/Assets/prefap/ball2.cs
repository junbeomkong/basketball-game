﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
    private float power2;
    public float power_plus2 = 400.0f;

    // Start is called before the first frame update
    
    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
           this.transform.position = new Vector3(-0.276f, 3.4f, -8.26f);
        }
        if (Input.GetMouseButton(0) && this.transform.position.z < -7.0f)
        {
            power2 += power_plus2 * Time.deltaTime;
        }
        if(Input.GetMouseButtonUp(0) && this.transform.position.z < -7.0f)
        {
            
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, power2, power2)) ;
            power2 = 0;
            
        }
        if (this.transform.position.y < 1.8f)
        {
            this.transform.position =new Vector3(-0.52f, 2.0f, -5.65f);
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<AudioSource>().Play();
    }

}