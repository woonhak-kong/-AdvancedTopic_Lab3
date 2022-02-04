using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCommand : ICommand
{
    private GameObject _gameObject;
    private Color _color;
   
    public ColorCommand(GameObject obj, Color color)
    {
        _gameObject = obj;
        _color = color;
    }

    public void Execute()
    {
        _gameObject.GetComponent<Renderer>().material.color = _color;
    }

    public void Undo()
    {
        // don't need to undo
    }
}
