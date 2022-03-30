using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] public SpriteRenderer _renderer;
    [SerializeField] public GameObject _highlight;
    public bool truth;
    public int turn;

    private void Start()
    {
        turn = 0;
        truth = false;
    }
    void OnMouseEnter()
    {
        truth = true;
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
    private void OnMouseDown()
    {
        turn++;
        if (turn % 2 == 0)
        {

            truth = true;
            _highlight.SetActive(true);
            _renderer.color = _baseColor;

        }
        else
        {

            truth = true;
            _highlight.SetActive(true);
            _renderer.color = _offsetColor;
            turn++;
        }

    }
}