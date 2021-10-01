using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text kills;
    public Text Gears;
    public int Currentgears = 500;
    public int currentkills = 0;

    public GameObject LossScreen;

    void Start()
    {
        Gears.text = "Gears : " + Currentgears;
        kills.text = "Kills : " + currentkills;
    }

    void Update()
    {
        Gears.text = "Gears : " + Currentgears;
        kills.text = "Kills : " + currentkills;

        if (Currentgears <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Time.timeScale = 0;
        LossScreen.SetActive(true);
    }
}
