using Godot;
using System;

public class ScoreDisplay : Control
{
    private Label _scoreLabel;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
       _scoreLabel = GetNode<Label>("ScoreLabel");
    }

    public void DisplayScore(float score)
    {
        _scoreLabel.Text = score.ToString();
    }

    public void OnButtonClick()
    {
        _scoreLabel.Text = (float.Parse(_scoreLabel.Text) + 1).ToString();
    }
}
