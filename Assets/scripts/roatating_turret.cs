using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roatating_turret : MonoBehaviour
{
    public float speed = 30f;

    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.back);
    }
}
