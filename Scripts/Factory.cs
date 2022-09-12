using Godot;

public static class Factory
{
    public static class PersonFactory
    {
        public static PersonBase CreateJohn()
        {
            var scene = GD.Load<PackedScene>("res://Scenes/People/John.tscn");
            var person = scene.Instance<John>();
            return person;
        }
    }
}