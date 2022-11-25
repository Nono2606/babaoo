using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TilesConstructor : MonoBehaviour
{
    [SerializeField]
    Sprite[] IOS;
    [SerializeField]
    Sprite[] Android;
    private void Awake()
    {
        
    }
    void Start()
    {
        for(int i = 0; i < IOS.Length; i++)
        {
#if UNITY_ANDROID
            transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = IOS[i];
#endif

        }
    }
}
