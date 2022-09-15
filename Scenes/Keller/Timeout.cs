using Godot;
using System;
using System.Linq;

public class Timeout : Area2D
{

    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void OnInputEvent(Viewport viewPort, InputEvent eventArgs, int shape_idx)
    {
        // if (eventArgs.IsActionReleased("mouse_click"))
        // {
        //     var bodies = GetOverlappingAreas();
        //     var person = bodies.OfType<PersonSlot>().FirstOrDefault();
        //     if (person != null)
        //     {

        //     }
        // }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
