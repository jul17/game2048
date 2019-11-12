using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class TileStyle
{
    public string Number;
    public Color32 TileColor;
    public Color32 TextColor;
}

public class TileStyleHolder : MonoBehaviour
{
    public static TileStyleHolder Instance;
    public TileStyle[] TileStyles;
    
    // SINGLETON
    private void Awake()
    {
        Instance = this;
    }
}
