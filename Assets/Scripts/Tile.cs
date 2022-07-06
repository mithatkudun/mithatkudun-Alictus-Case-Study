using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private static Tile selected;
    public Vector2Int Position;
    private SpriteRenderer Renderer; // 2

    private void Start() // 3
    {
        Renderer = GetComponent<SpriteRenderer>();
        changeTileTag(gameObject);
    }
    public void changeTileTag(GameObject parent)
    {
        Transform t = parent.transform;

        if (t.GetChild(0).gameObject.tag == "Banana")
        {
        gameObject.tag = "Banana";
        }
        if (t.GetChild(0).gameObject.tag == "Cherry")
        {
            gameObject.tag = "Cherry";
        }
        if (t.GetChild(0).gameObject.tag == "Watermelon")
        {
            gameObject.tag = "Watermelon";
        }
    }
    public void Select() // 4
    {
        Renderer.color = Color.grey;
    }

    public void Unselect() // 5 
    {
        Renderer.color = Color.white;
    }
        private void OnMouseDown()
        {
            if (selected != null)
            {
                if (selected == this)
                    return;
                selected.Unselect();
                if (Vector2Int.Distance(selected.Position, Position) == 1)
                {
                    SeparateGrids.Instance.SwapTiles(Position, selected.Position);
                    selected = null;
                }
                else
                {
                    selected = this;
                    Select();
                }
            }
            else
            {
                selected = this;
                Select();
            }
        }
}

