using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonCursor : MonoBehaviour
{

    public Texture2D cursorArrow;
    public Texture2D cursorArrow2;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}