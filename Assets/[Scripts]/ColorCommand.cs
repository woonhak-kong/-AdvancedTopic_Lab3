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

    public bool Execute()
    {
        _gameObject.GetComponent<Renderer>().material.color = _color;
        return true;
    }

    public bool Undo()
    {
        // don't need to undo
        return false;
    }
}
