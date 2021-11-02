using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThresholds;
     private float _origanlspeed;

    private Path _path;
    private WayPoints _currentWaypoint;

    
    public void SlowedEnemy(bool GetSlowed)
    {
        if (GetSlowed == true)
        {
            _speed = _speed /  1.5f;
        }
        else
        {
            _speed = _origanlspeed;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _origanlspeed = _speed;
        SetupPath();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WaypointPosition = _currentWaypoint.GetPosition();
        transform.LookAt(_currentWaypoint.GetPosition() + new Vector3(0, transform.position.y, 0));
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float DistanceToWaypoint = Vector3.Distance(transform.position, WaypointPosition);
        if (DistanceToWaypoint < _arrivalThresholds)
        {
            //Debug.Log("NEXT ONE");

            if (_currentWaypoint == _path.GetEndPath())
            {
                pathComplete();
            }
            else
            {
                _currentWaypoint = _path.NextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());
            }
        }
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetWaypoint();
    }

    private void pathComplete()
    {
        //Debug.Log("PathComplete");
        Destroy(gameObject);
    }
}
