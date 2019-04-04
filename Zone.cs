using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public float speed;

    void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move();
        }
    }

    void Move()
    {
        this.transform.Translate(Vector3.forward  * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "water")
        {
            Debug.Log("OnWater");
        }
        else if (collision.gameObject.tag == "sand")
        {
            Debug.Log("OnSand");
        }
        else if (collision.gameObject.tag == "grass")
        {
            Debug.Log("OnGrass");
        }
        else if (collision.gameObject.tag == "safe")
        {
            Debug.Log("OnSafe");
        }
        else if (collision.gameObject.tag == "normal")
        {
            Debug.Log("OnNormal");
        }
        else if (collision.gameObject.tag == "danger")
        {
            Debug.Log("OnDanger");
        }
    }

}
