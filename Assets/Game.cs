using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{


    [SerializeField] private Transform emptyTile = null;
    //Liste des tales
    public List<GameObject> TaleList = new List<GameObject>();
    //Liste des positions
    public List<Transform> Talepos = new List<Transform>();
    
    void Start()
    {
        //Mélange les positions
        Shuffle(Talepos);
        //Place aléatoirement les Tales
        for (int i = 0; i < TaleList.Count; i++)
        {
            TaleList[i].transform.position = Talepos[i].position;
        }
        
    }
    #region Mélange une liste
    void Shuffle<T>(List<T> inputList)
    {
        for (int i = 0; i < inputList.Count - 1; i++)
        {
            T temp = inputList[i];
            int rand = Random.Range(i, inputList.Count);
            inputList[i] = inputList[rand];
            inputList[rand] = temp;
        }
    }
    #endregion
 
}
