using TextBasedRPG.Monsters;

namespace TextBasedRPG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("longsword".ToUpper());
        Dragon dragon = SpawnMonster.Dragon();
        Orc orc = SpawnMonster.Orc();
        MindFlayer mindFlayer = SpawnMonster.MindFlayer();
        Goblin goblin = SpawnMonster.Goblin();
        
        dragon.ShowStats();
        Character player = CreateCharacter.Player();
        player.ShowStats();
        player.CheckInventory();
        player.RollToAttack(dragon);
        player.RollToAttack(dragon);
        player.RollToAttack(dragon);
        player.RollToAttack(dragon);
        dragon.ShowStats();
        dragon.RollToAttack(player);
        dragon.RollToAttack(player);
        player.ShowStats();




    }
}
