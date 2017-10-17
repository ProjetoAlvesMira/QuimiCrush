using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridItem : MonoBehaviour {

    public int x { get; private set; }
    public int y { get; private set; }

    public void OnItemPositionChange(int newX, int newY)
    {
        x = newX;
        y = newY;
        gameObject.name = string.Format("Sprite [{0}] [{1}]", x, y);
    }

    private void OnMouseDown()
    {
        if (OnMouseOverItemEventHandler != null)
            OnMouseOverItemEventHandler(this);
    }

    public delegate void OnMOuseOverItem(GridItem item);
    public static event OnMOuseOverItem OnMouseOverItemEventHandler;




}
