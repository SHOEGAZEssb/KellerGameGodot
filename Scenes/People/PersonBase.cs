using Godot;
using System;

public class PersonBase : Sprite
{
    [Export]
    public bool IsActive = true;

    [Export]
    public string PersonName = "Unnamed";

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



    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
