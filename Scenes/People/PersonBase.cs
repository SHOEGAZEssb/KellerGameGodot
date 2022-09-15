using Godot;
using System;
using System.Linq;

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

    private int _slotID;

    private bool _isMouseOver;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void OnMouseEntered()
    {
        _isMouseOver = true;
    }

    public void OnMouseExited()
    {
        _isMouseOver = false;
    }

    public override void _Input(InputEvent @event)
    {
        if (_isMouseOver)
        {
        if (@event.IsActionPressed("mouse_click"))
            _dragging = true;
        else if (@event.IsActionReleased("mouse_click"))
        {
            _dragging = false;
            var bodies = GetOverlappingAreas();
            var slot = bodies.OfType<PersonSlot>().FirstOrDefault();
            var timeout = bodies.OfType<Timeout>().FirstOrDefault();
            if (slot != null)
            {
                slot.Activate(this);
                _slotID = slot.SlotIndex;
            }
            else if (timeout != null)
            {
                GD.Print(_slotID);
                var children = GetTree().GetNodesInGroup("PersonSlots");
                GD.Print(children.Count);
                var oldSlot = children.OfType<PersonSlot>().Where(s => s.SlotIndex == _slotID).FirstOrDefault();
                if (oldSlot != null)
                {
                    oldSlot.Deactivate(this);
                    _slotID = -1;
                }
            }

        }

        GetTree().SetInputAsHandled();
        }
    }

    public void OnInputEvent(Viewport viewPort, InputEvent eventArgs, int shape_idx)
    {
        
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if (_dragging)
            Position = GetGlobalMousePosition();
    }
}
