using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownCommand : ICommand
{
    private Transform _transform;
    private Vector3 _oldPosition;
    //private Vector3 _newPosition;

    public MoveDownCommand(Transform transform)
    {
        _transform = transform;
    }

    public void Execute()
    {
        _oldPosition = _transform.position;
        _transform.Translate(-_transform.up);
        //_transform.position.y = 1.0f;
    }

    public void Undo()
    {
        _transform.position = _oldPosition;
    }
}
