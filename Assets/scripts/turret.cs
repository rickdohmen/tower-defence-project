using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public Transform target;
    List<GameObject> Enemy = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(Enemy[0].transform, Vector3.left);
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy.Add(other.gameObject);
        Enemy.Remove(new GameObject());
    }
}
