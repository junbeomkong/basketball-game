using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float power;
    public float power_plus = 400.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.transform.position = new Vector3(-0.276f, 3.4f, -8.26f);
        }
        if (Input.GetMouseButton(0) && transform.position.z < -7.0f)
        {
            power += power_plus * Time.deltaTime;
        }
        if (Input.GetMouseButtonUp(0) && this.transform.position.z < -7.0f)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, power, power));
            power = 0;
        }
        if (this.transform.position.y < 1.8f)
        {
            this.transform.position = new Vector3(-0.01f, 3.35f, -5.65f);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<AudioSource>().Play();
    }

}
