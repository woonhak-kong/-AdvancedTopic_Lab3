using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CommandManager.Instance.Execute(new MoveUpCommand(transform));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CommandManager.Instance.Execute(new MoveDownCommand(transform));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CommandManager.Instance.Execute(new MoveLeftCommand(transform));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CommandManager.Instance.Execute(new MoveRightCommand(transform));
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CommandManager.Instance.Execute(new ColorCommand(gameObject, new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f))));
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            CommandManager.Instance.Undo();
        }
    }
}
