using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject GO;
    [SerializeField] int Length, Width;


    private void Awake()
    {
        SpawnGOss();
    }
    public void SpawnGOss()
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                
                Instantiate(GO, new Vector3(i, 0, j), Quaternion.Euler(90,0,0));
            }
        }
    }
}
