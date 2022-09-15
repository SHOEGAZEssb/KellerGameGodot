using Godot;
using System;

public class ScoreDisplay : Control
{
    private Label _scoreLabel;
    private Game _game;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _scoreLabel = GetNode<Label>("ScoreLabel");
        _game = GetTree().Root.GetNode<Game>("Game");
    }

    public void DisplayScore(float score)
    {
        _scoreLabel.Text = score.ToString();
    }

    public void OnButtonClick()
    {
        _game.Caps += 1;
    }
}
