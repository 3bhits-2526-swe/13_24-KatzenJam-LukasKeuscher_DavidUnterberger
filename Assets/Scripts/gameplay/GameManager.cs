using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int cole;
    public Text coleDisplay;

    private Building buildingToPlace;
    public GameObject grid;

    public CustomCursor customCursor;

   

    private void Update()
    {
        coleDisplay.text = cole.ToString();

        
    }

    public void BuyBuilding(Building building)
    {
        if(cole >= building.cost)
        {
            customCursor.gameObject.SetActive(true);
            customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible = false;


            cole -= building.cost;
            buildingToPlace = building;
            grid.SetActive(true);
        }
    }
}
