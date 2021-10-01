using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 100;
    public float speed = 1;

    public int BulletDmg = 3;
    

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

            GameObject UI = GameObject.Find("GameManager");
            UIManager uimanager = UI.GetComponent<UIManager>();
            uimanager.currentkills += 1;


            Destroy(gameObject);
        }

        transform.position += Vector3.back * speed * Time.deltaTime;

        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //Debug.Log("Hit");
            health = health - BulletDmg;
        }

        

        if (other.gameObject.tag == "EndPoint")
        {
            GameObject UI = GameObject.Find("GameManager");
            UIManager uimanager = UI.GetComponent<UIManager>();
            uimanager.Currentgears -= 25;

            Destroy(gameObject);

        }
    }

}

internal class UImanaager
{

}