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
    Color t;
    public Square s;
    public Square s1;
    bool istrue;

    bool press;

    string prev;

    // Start is called before the first frame update
    void Start()
    {
        istrue = false;
        press = false;
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
        
    }
    void OnMouseDown()
    {
        t = thingy.color;
        prev = player.text;
        if (players == 2)
        {
            if (player.text == "1" && (sprite.color == Color.clear || istrue == false))
            {
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
                istrue = true;
            }
            if (player.text == "2" && sprite.color == Color.clear || istrue == false)
            {
                t = thingy.color;
                sprite.color = Color.blue;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
                istrue = true;
            }
        }
        if (players == 3)
        {
            if (player.text == "1" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
                istrue = true;
            }
            if (player.text == "2" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.blue;
                thingy.color = Color.green;
                thingy2.color = Color.green;
                player.SetText("3");
                istrue = true;
            }
            if (player.text == "3" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.green;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
                istrue = true;
            }
        }
        if (players == 4)
        {
            if (player.text == "1" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.red;
                thingy.color = Color.blue;
                thingy2.color = Color.blue;
                player.SetText("2");
                istrue = true;
            }
            if (player.text == "2" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.blue;
                thingy.color = Color.green;
                thingy2.color = Color.green;
                player.SetText("3");
                istrue = true;
            }
            if (player.text == "3" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.green;
                thingy.color = Color.yellow;
                thingy2.color = Color.yellow;
                player.SetText("4");
                istrue = true;
            }
            if (player.text == "4" && sprite.color == Color.clear || istrue == false)
            {
                sprite.color = Color.yellow;
                thingy.color = Color.red;
                thingy2.color = Color.red;
                player.SetText("1");
                istrue = true;
            }
        }

        if(transform.gameObject.name == "_1" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "_2" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "_3" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "_4" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_5" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_6" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_7" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_8" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_9" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if ((s.val == 4 || s1.val == 4))
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "_10" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "_11" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "_12" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }

        if (transform.gameObject.name == "1" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "2" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "3" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "4" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "5" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "6" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "7" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "8" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "9" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }
        if (transform.gameObject.name == "10" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "11" && press == false)
        {
            s.val++;
            s1.val++;
            press = true;
            if (s.val == 4 || s1.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
                s1.press();
            }
        }
        if (transform.gameObject.name == "12" && press == false)
        {
            s.val++;
            press = true;
            if (s.val == 4)
            {
                player.SetText(prev);
                thingy.color = t;
                thingy2.color = t;
                s.press();
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
