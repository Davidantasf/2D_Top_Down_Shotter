using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorDia;
    

    void Start()
    {
        Vector2 cursorOffset = new Vector2(cursorArrow.width/2, cursorArrow.height/2);
        Cursor.SetCursor(cursorArrow, cursorOffset, CursorMode.Auto);
    }
    void OnMouseEnter()
    {
        Vector2 cursorOffset = new Vector2(cursorDia.width/2, cursorDia.height/2);
        Cursor.SetCursor(cursorDia, cursorOffset, CursorMode.Auto);
        
    }
    void OnMouseExit()
    {
        Vector2 cursorOffset = new Vector2(cursorArrow.width/2, cursorArrow.height/2);
        Cursor.SetCursor(cursorArrow, cursorOffset, CursorMode.Auto);
    }
    
    
    
    
    
    
    
    //void Start()
    //{
    //    Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    //}
    //void OnMouseEnter()
    //{
     //   Cursor.SetCursor(cursorDia, Vector2.zero, CursorMode.ForceSoftware);
    //}
    //void OnMouseExit()
    //{
    //    Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    //}
}
