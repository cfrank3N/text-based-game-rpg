using TextBasedRPG.Monsters;

namespace TextBasedRPG;

public static class SpawnMonster
{
    public static Dragon Dragon()
    {
        Dragon d = new Dragon();
        Console.WriteLine("Spawning Dragon...watch out for fire...");
        return d;
    }
    
    public static Dragon RedDragon()
    {
        Dragon r = new Dragon("Red Dragon");
        Console.WriteLine("Spawning a Red Dragon...watch out for fire...");
        return r;
    }

    public static Goblin Goblin()
    {
        Goblin g = new Goblin();
        Console.WriteLine("Spawning monster...");
        return g;
    }

    public static MindFlayer MindFlayer()
    {
        MindFlayer m = new MindFlayer();
        Console.WriteLine("Spawning a Mind Flayer in your surroundings...watch your head...");
        return m;
    }

    public static Orc Orc()
    {
        Orc o = new Orc();
        Console.WriteLine("Spawning a green monster...");
        return o;
    }
}