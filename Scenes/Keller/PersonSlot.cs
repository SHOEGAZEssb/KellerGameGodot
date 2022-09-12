using Godot;
using System;
using System.Linq;

public class PersonSlot : Area2D
{
    public int SlotIndex = 0;

    private PersonBase _person;

    [Export]
    public Game _game;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _game = GetTree().Root.GetNode<Game>("Game");
    }

    public void OnInputEvent(Viewport viewPort, InputEvent eventArgs, int shape_idx)
    {
        if (eventArgs.IsActionReleased("mouse_click"))
        {
            var bodies = GetOverlappingAreas().OfType<PersonBase>();
            var person = bodies.First(p => p != _person);
            if (_person == null)
            {
                _game.SetActivePerson(person, SlotIndex);
                _person = person;
            }

        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
