using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptySpace : MonoBehaviour
{
    private Tile _objectInside;
    void Update()
    {
        //Si la souris est lacher et que il y a un objet dans le collider
        if (Input.GetMouseButtonUp(0) && _objectInside)
        {
            _objectInside.SwapPlace(transform);
            _objectInside = null;
        }
    }
    //On regarde si l'objet en collision est du type tile
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Tile t))
        {
            _objectInside = t;
        }

    }
    //On regarde si l'objet qui quitte est de type tile
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Tile t))
        {
            _objectInside = null;
        }
    }
}
