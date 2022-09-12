using Godot;
using System;

public class BuyMenu : Control
{
    private Game _game;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _game = GetTree().Root.GetNode<Game>("Game");
    }

    public void OnBuyButtonClicked()
    {
        var person = Factory.PersonFactory.CreateJohn();
        if (_game.BuyPerson(person))
        {

        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
