
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    //public bool throttle => Input.GetKey(KeyCode.Space);

    public float rotatie, viteza, vitezaIncrease;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.forward * viteza * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotatie * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotatie * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(rotatie * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-rotatie * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, rotatie * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -rotatie * Time.deltaTime);
        }
        
    }
    public void increaseSpeed()
    {
        viteza += vitezaIncrease;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Coin")
        {
            increaseSpeed();
        }
    }
}