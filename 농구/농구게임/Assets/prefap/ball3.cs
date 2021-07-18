using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball3 : MonoBehaviour
{
    private float power3;
    public float power_plus3 = 400.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.transform.position = new Vector3(-0.276f, 3.4f, -8.26f);
        }
        if (Input.GetMouseButton(0) && this.transform.position.z < -7.0f)
        {
            power3 += power_plus3 * Time.deltaTime;
        }
        if (Input.GetMouseButtonUp(0) && this.transform.position.z < -7.0f)
        {

            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, power3, power3));
            power3 = 0;

        }
        if (this.transform.position.y < 1.8f)
        {
            this.transform.position = new Vector3(-0.98f, 3.35f, -5.65f);
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<AudioSource>().Play();
    }
}