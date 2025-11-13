using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridBuildingSystem : MonoBehaviour
{

    public static GridBuildingSystem current;

    public GridLayout gridLayout;
    public Tilemap MainTilemap;
    public Tilemap TempTilemap;

    #region Unity Methods


    private void Update()
    {
        
    }

    void Awake()
    {
        current = this;
    }

    void Start()
    {
        
    }
    #endregion

    #region Tilemap Management

    #endregion

    #region Building Placement

    #endregion

    public enum TileType
    {
        Empty
    }
}
