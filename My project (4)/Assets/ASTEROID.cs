using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASTEROID : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

            if (other.gameObject.tag == "Plane")
            {
                
                ScoreManager.instance.decreaseScore();
            }
    }
    
}