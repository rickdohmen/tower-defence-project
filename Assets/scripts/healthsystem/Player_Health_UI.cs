using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health_UI : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Player_Health_Component _Player_Health_Component;

   

    public void UpdateUI(float nr0fLives)
    {
        
       _text.text = "Gears: " + nr0fLives;
    }
}
