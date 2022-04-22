using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class pressed : MonoBehaviour
{
    public TextMeshProUGUI player;
    int players;
    int size;
    SpriteRenderer sprite;
    public SpriteRenderer thingy;
    public SpriteRenderer thingy2;
    private SpriteRenderer adjh;
    private SpriteRenderer adjv;
    bool istrue;
    // Start is called before the first frame update
    void Start()
    {
        istrue = false;
        int count = 0;
        
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Color.clear;
        foreach (string line in System.IO.File.ReadLines("Assets/Settings.txt"))
        {
            if (count == 0)
            {
                players = Int32.Parse(line);
            }
            if (count == 1)
            {
                size = Int32.Parse(line);
            }
            count++;
        }
    }
    private void OnMouseOver()
    {
        if (sprite.color == Color.white)
        {
            if (player.text == "1")
            {
                sprite.color = Color.red;
                istrue = false;
            }
            if (player.text == "2")
            {
                sprite.color = Color.blue;
                istrue = false;
            }
            if (player.text == "3")
            {
                sprite.color = Color.green;
                istrue = false;
            }
            if (player.text == "4")
            {
                sprite.color = Color.yellow;
                istrue = false;
            }
        }
    }
    void OnMouseExit()
    {
        if (istrue == false)
        {
            sprite.color = Color.white;
            istrue = true;
        }
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
    void OnMouseDown()
    {
        Debug.Log("hi");
        if (players == 2)
        {
            if (player.text == "1" && (sprite.color == Color.clear || istrue == false))
            {
                Debug.Log("hi");
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
                istrue = true;
            }
            if (player.text == "2" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.blue;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
                istrue = true;
            }
        }
        if (players == 3)
        {
            if (player.text == "1" && sprite.color == Color.clear)
            {
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
            }
            if (player.text == "2" && sprite.color == Color.clear)
            {
                sprite.color = Color.blue;
                thingy.color = Color.green;
                thingy2.color = Color.green;
                player.SetText("3");
            }
            if (player.text == "3" && sprite.color == Color.clear)
            {
                sprite.color = Color.green;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
            }
        }
        if (players == 4)
        {
            if (player.text == "1" && sprite.color == Color.clear)
            {
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
            }
            if (player.text == "2" && sprite.color == Color.clear)
            {
                sprite.color = Color.blue;
                thingy.color = Color.green;
                thingy2.color = Color.green;
                player.SetText("3");
            }
            if (player.text == "3" && sprite.color == Color.clear)
            {
                sprite.color = Color.green;
                thingy.color = Color.yellow;
                thingy2.color = Color.yellow;
                player.SetText("4");
            }
            if (player.text == "4" && sprite.color == Color.clear)
            {
                sprite.color = Color.yellow;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
