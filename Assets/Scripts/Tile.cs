using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 initialPos;
    private Vector3 curPosition;

    #region MouseManagement
    private void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        initialPos = gameObject.transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

        transform.position = curPosition;   
    }
    #endregion
    //Appeler dans la classe empty lorsque'on lache là souris et qu'il y a une collision 
    public void SwapPlace(Transform emptyPos)
    {
        var currentPos = initialPos;

        transform.position = emptyPos.position;

        emptyPos.position = initialPos;

    }
}
