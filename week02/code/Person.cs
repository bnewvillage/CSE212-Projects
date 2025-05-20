public class Person
{
    public readonly string Name;
    public bool Infinite = false;
    public int Turns { get; set; }

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
        if (Turns <= 0){
            Infinite = true;
        }
    }
}