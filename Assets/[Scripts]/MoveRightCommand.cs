using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    private Transform _transform;
    private Vector3 _oldPosition;
    //private Vector3 _newPosition;

    public MoveRightCommand(Transform transform)
    {
        _transform = transform;
    }

    public void Execute()
    {
        _oldPosition = _transform.position;
        _transform.Translate(_transform.right);
        //_transform.position.y = 1.0f;
    }

    public void Undo()
    {
        _transform.position = _oldPosition;
    }
}
