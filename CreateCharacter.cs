using TextBasedRPG.Weapons;

namespace TextBasedRPG;

public static class CreateCharacter
{
    public static Character Player()
    {
        Console.WriteLine("Welcome to the character creator.");
        string name = CreateCharacter.GetName();
        Weapon weapon = CreateCharacter.GetWeapon();
        
        Character player = new Character(name);
        player.EquipWeapon(weapon);
        return player;
    }

    public static string GetName()
    {
        Console.WriteLine("\nGive your character a name: ");
        string? playerName = Console.ReadLine();

        return playerName;
    }

    public static Weapon GetWeapon()
    {
        Console.WriteLine("What kind of Weapon do you want to equip?\n\nGreatsword\n\nLongsword\n\nStaff\n");
        string pWeapon = Console.ReadLine();

        Weapon playerWeapon = new Weapon();
        
        switch (pWeapon.ToUpper())
        {
            case "GREATSWORD" : playerWeapon = new GreatSword();
                break;
            case "LONGSWORD" : playerWeapon = new LongSword();
                break;
            case "STAFF" : playerWeapon = new Staff();
                break;
            default : playerWeapon = new Staff();
                break;
        }
        return playerWeapon;
    }
}