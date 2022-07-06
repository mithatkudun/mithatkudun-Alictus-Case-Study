using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateGrids : MonoBehaviour
{
    public List<GameObject> foods = new List<GameObject>();
    public GameObject TilePrefab;
    public int GridDimensionx = 5;
    public float Distancex = 0.46f;
    public float Distancez = 0.66f;
    public int GridDimensionz = 6;
    public int list;
    private GameObject[,] Grid;
    Tile tile;
    public static SeparateGrids Instance { get; private set; }
    void Awake() { Instance = this; }
    void Start()
    {
        Tile tile = GetComponent<Tile>();
        Grid = new GameObject[GridDimensionx, GridDimensionz];
        InitGrid();
    }
   public void InitGrid()
    {       

        Vector3 positionOffset = transform.position - new Vector3(GridDimensionx * Distancex , 0, GridDimensionz * Distancez); 
        for (int row = GridDimensionz-1; row >= 0; row--)           
            for (int column = 0; column < GridDimensionx ; column++) 
            {   
                list++;
                GameObject newTile = Instantiate(TilePrefab); 
                GameObject food = newTile.GetComponent<GameObject>();                            
                newTile.transform.parent = transform; 
                newTile.transform.position = new Vector3(column * Distancex, 0, row * Distancez) + positionOffset; 
                food = Instantiate(foods[list - 1], newTile.transform.position, Quaternion.identity);
                food.transform.parent = newTile.transform;
                Tile tile = newTile.AddComponent<Tile>();
                tile.Position = new Vector2Int(column ,  row);
                Grid[column, row] = newTile; 
                Renderer newTilemesh = newTile.GetComponent<Renderer>();
                newTilemesh.enabled = false;
                SpriteRenderer renderer = newTile.GetComponent<SpriteRenderer>();
            }

    }
    public void SwapTiles(Vector2Int tile1Position, Vector2Int tile2Position)
    {
        GameObject tile1 = Grid[tile1Position.x, tile1Position.y];                
        GameObject tile2 = Grid[tile2Position.x, tile2Position.y];
        if (Vector2Int.Distance(tile1Position, tile2Position) == 1)
        {
            tile1.transform.position = tile2.transform.position;
            
        }
        
    }
}
 

