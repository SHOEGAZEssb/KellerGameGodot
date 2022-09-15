using Godot;
using System;
using System.Linq;

public class PersonSlot : Area2D
{
    [Export]
    public int SlotIndex = 0;

    private Node2D _personPosition;

    private PersonBase _person;

    private Game _game;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _game = GetTree().Root.GetNode<Game>("Game");
        _personPosition = GetNode<Node2D>("PersonPosition");
    }

    public void Activate(PersonBase person)
    {
        if (_person == null)
        {
            _game.SetActivePerson(person, SlotIndex);
            _person = person;
            _person.Position = _personPosition.GlobalPosition;
        }
        else
        {
            if (_person != person)
            {

            }
        }
    }

    public void Deactivate(PersonBase person)
    {
        GD.Print("Deactivate");
        _person = null;
        _game.DeactivatePerson(person);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
