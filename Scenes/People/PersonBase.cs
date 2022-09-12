using Godot;
using System;

public class PersonBase : Area2D
{
    [Export]
    public bool IsActive = true;

    [Export]
    public string PersonName = "Unnamed";

    [Export]
    public float InitialCost = 10f;

    [Export]
    public float BaseCapsPerSecond = 1f;

    [Export]
    public float CapsPerSecond = 1f;

    [Export]
    public float BaseCigarettesPerSecond = 1f;

    [Export]
    public float CigarettesPerSecond = 1f;

    [Export]
    public float BaseWeedPerSecond = 1f;

    [Export]
    public float WeedPerSecond = 1f;

    private bool _dragging;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void OnInputEvent(Viewport viewPort, InputEvent eventArgs, int shape_idx)
    {
        GD.Print("input event");
        if (eventArgs.IsActionPressed("mouse_click"))
            _dragging = true;
        else if (eventArgs.IsActionReleased("mouse_click"))
            _dragging = false;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if (_dragging)
            Position = GetGlobalMousePosition();
    }
}
