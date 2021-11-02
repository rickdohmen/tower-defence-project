using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    private Tile _selectedTile = null;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && _selectedTile == null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layer))
            {
                Tile tile = hit.transform.GetComponent<Tile>();
                _selectedTile = tile;
                print("klik tile");
            }
        }
    }
}
