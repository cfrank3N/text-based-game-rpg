using TextBasedRPG.Monsters;
using TextBasedRPG.Weapons;
using TextBasedRPG.Dice;

namespace TextBasedRPG;

public class Character
{
    //Fields
    private int health;
    
    //Properties
    public int Strength { get; protected set; }
    public int Dexterity { get; protected set; }
    public int Wisdom { get; protected set; }
    public int Constitution { get; protected set; } 
    public int Health
    {
        get => health;
        protected set
        {
           if ((health = value) < 0) 
           {
               health = 0;
           }
           else
           {
               health = value;
           }
        } 
    }
    public int StartingHealth { get; protected set; }
    public int ArmorClass { get; protected set; }
    public string Name { get; set; }
    public Weapon EquippedWeapon { get; protected set; }
    
    //Constructors
    public Character(string name)
    {
        Name = name;
        RollForCharacterStats();
        Health = DetermineHealth(Constitution);
        ArmorClass = DetermineArmorClass(Dexterity);
        StartingHealth = Health;
    }

    public Character()
    {
    }
    
    //Methods and Functions Stats
    public virtual void ShowStats()
    {
        Console.WriteLine("O==|=====> *x*x** 0=|)==> **##** >-|)--> %%&&**|||||/// CHARACTER SHEET\\\\\\||||| %%&&** <--(|-< **##** <==(|=0 *x*x** <=====|==O");
        Console.WriteLine($"                o==||====> Name: {Name}");
        Console.WriteLine($"                o==||====> Armor Class: {ArmorClass}");
        Console.WriteLine($"                o==||====> Strength: {Strength}");
        Console.WriteLine($"                o==||====> Dexterity: {Dexterity}");
        Console.WriteLine($"                o==||====> Constitution: {Constitution}");
        Console.WriteLine($"                o==||====> Wisdom: {Wisdom}");
        Console.WriteLine($"                o==||====> Remaining health: {Health}/{StartingHealth}");
        Console.WriteLine("O==|=====> *x*x** 0=|)==> **##** >-|)--> %%&&**|||||/// THE DUNGEON AWAITS\\\\\\||||| %%&&** <--(|-< **##** <==(|=0 *x*x** <=====|==O ");
    }
    
    protected int DetermineHealth(int constitution)
    {
        int health = 0;
        switch (constitution)
        {
            case >23 : health = 50;
                break;
            case >17 : health = 45;
                break;
            case >12 : health = 40;
                break;
            case >7 : health = 35;
                break;
            default: health = 30;
                break;
        }

        return health;
    }

    protected int DetermineArmorClass(int dexterity)
    {
        int armorClass;

        switch (dexterity)
        {
            case >23: armorClass = 18;
                break;
            case >17: armorClass = 16;
                break;
            case >12: armorClass = 14;
                break;
            case >7: armorClass = 13;
                break;
            default:
                armorClass = 10;
                break;
        }

        return armorClass;
    }
    protected virtual void RollForCharacterStats()
    {
        Console.WriteLine("Rolling for stats...");
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat();
        this.Dexterity = s.RollStat();
        this.Wisdom = s.RollStat();
        this.Constitution = s.RollStat();
    }
    
    //Actions
    public void TakeDamage(int damage) => Health -= damage;
    
    public void CheckInventory()
    {
        Console.WriteLine($"Equipped weapon: {EquippedWeapon.TypeOfWeapon}");
    }
    public void EquipWeapon(Weapon w)
    {
        EquippedWeapon = w;
    }

    public void UnEquipWeapon(Weapon w)
    {
        
    }
    
    public void DealDamageTo(Monster monsterToDamage, int damage)
    {
        monsterToDamage.Health -= damage;
        Console.WriteLine($"The {monsterToDamage.TypeOfMonster} took {damage} points of damage.");
    }

    public void RollToAttack(Monster monster)
    {
        TwentySidedDice d = new TwentySidedDice();
        int resultOfRoll = d.RollDice(1);
        int monsterAC = monster.ArmorClass;

        if (resultOfRoll >= monsterAC)
        {
            Console.WriteLine($"You rolled a {resultOfRoll} against the {monster.TypeOfMonster}'s armor class {monsterAC}");
            Console.WriteLine($"Attacking the {monster.TypeOfMonster}");
            AttackMonsterWithWeapon(monster, EquippedWeapon);
        }
        else
        {
            Console.WriteLine($"You rolled a {resultOfRoll} against the {monster.TypeOfMonster}'s armor class {monsterAC}");
            Console.WriteLine($"Your attempt to attack the {monster.TypeOfMonster} failed.");
        }
    }
    
    public void AttackMonsterWithWeapon(Monster monsterToAttack, Weapon attackWithWeapon)
    {
        Console.WriteLine($"{Name} attacks the {monsterToAttack.TypeOfMonster} with {EquippedWeapon.TypeOfWeapon}");
        int damage = EquippedWeapon.DamageDice.RollDice(EquippedWeapon.NumberOfDamageRolls) + EquippedWeapon.DamageModifier;
        DealDamageTo(monsterToAttack, damage);
    }

    public virtual void CastSpell()
    {
        
    }
    
    public virtual void Defend()
    {
        
    }
}