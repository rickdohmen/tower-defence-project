using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSlow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<PathFollower>().SlowedEnemy(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<PathFollower>().SlowedEnemy(false);
        }
        
    }
}
