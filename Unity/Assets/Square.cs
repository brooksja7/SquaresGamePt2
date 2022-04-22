using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Square : MonoBehaviour
{
    public int val;
    SpriteRenderer sprite;
    public TextMeshProUGUI player;
    int max;
    // Start is called before the first frame update
    int[] score = new int[4];
    void Start()
    {
        
        val = 0;
        for(int x = 0; x < 3; x++)
        {
            score[x] = 0;
        }

    }
    public void press()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (val == 4)
        {
            max++;
            if (player.text == "1")
            {
                sprite.color = Color.red;
                score[0]++;
                
            }
            if (player.text == "2")
            {
                sprite.color = Color.blue;
                score[1]++;
            }
            if (player.text == "3")
            {
                sprite.color = Color.green;
                score[2]++;
            }
            if (player.text == "4")
            {
                sprite.color = Color.yellow;
                score[3]++;
            }
        }
        if (max == 9)
        {
            int highscore = 0;
            int winner = 0;
            for (int x = 0; x < 4; x++)
            {
                if (score[x] > highscore)
                {
                    winner = x;
                }
                Debug.Log("The winner is player: " + x);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
