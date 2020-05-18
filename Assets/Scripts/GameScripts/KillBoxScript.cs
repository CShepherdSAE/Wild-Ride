using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBoxScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obsticle")
        {
            Debug.Log("Obsticle is being triggered");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Cone")
        {
            Debug.Log("Cone is being triggered");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Coin is being triggered");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Health")
        {
            Debug.Log("Health is being triggered");
            Destroy(other.gameObject);
        }
        else
        {
            return;
        }
    }

}
