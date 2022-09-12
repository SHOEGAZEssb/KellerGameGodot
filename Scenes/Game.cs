using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public class Game : Node2D
{
    public float Caps = 0f;

    private PersonBase[] _activePersons = new PersonBase[3];
    private List<PersonBase> _inactivePersons = new List<PersonBase>();
    private ScoreDisplay _scoreDisplay;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _scoreDisplay = GetNode<ScoreDisplay>("ScoreDisplay");
        var john = GetNode<PersonBase>("John");
    }

    public void SetActivePerson(PersonBase person, int slotIndex)
    {
        if (_activePersons.Any(p => p == null))
        {
            _activePersons[slotIndex] = person;
            person.IsActive = true;
        }
    }

    public void DeactivatePerson(PersonBase person)
    {
        _activePersons[Array.IndexOf(_activePersons, person)] = null;
        _inactivePersons.Add(person);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        foreach(var person in _activePersons.Where(p => p != null))
        {
            Caps += person.CapsPerSecond * delta;
        }

        _scoreDisplay.DisplayScore(Caps);
    }
}
