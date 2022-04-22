using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class settings : MonoBehaviour
{
    private int player, grids;
    void Start()
    {
        
    }
    public void set_player(int players)
    {
        player = players;
    }
    public void grid(int grid)
    {
        grids = grid;
    }
    public void makegame()
    {
        string path = "Assets/Settings.txt";
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(player + "\n" + grids);
        writer.Close();


        

    }
}