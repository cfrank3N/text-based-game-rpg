using TextBasedRPG.Dice;
using TextBasedRPG.Weapons;

namespace TextBasedRPG.Monsters;

public class Monster : Character
{
    //Properties
    public string TypeOfMonster { get; protected set; }

    public Monster(string typeOfMonster) : base("Big Bad")
    {
        TypeOfMonster = typeOfMonster;
        //Inherits from Character Constructor
    }
    
    protected override void RollForCharacterStats()
    {
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat();
        this.Dexterity = s.RollStat();
        this.Wisdom = s.RollStat();
        this.Constitution = s.RollStat();
    }
    public override void ShowStats()
    {
        Console.WriteLine("O==|=====> *x*x** 0=|)==> **##** >-|)--> %%&&**|||||/// MONSTER SHEET\\\\\\||||| %%&&** <--(|-< **##** <==(|=0 *x*x** <=====|==O");
        Console.WriteLine($"                o==||====> Monster: {TypeOfMonster}");
        Console.WriteLine($"                o==||====> Armor Class: {ArmorClass}");
        Console.WriteLine($"                o==||====> Strength: {Strength}");
        Console.WriteLine($"                o==||====> Dexterity: {Dexterity}");
        Console.WriteLine($"                o==||====> Constitution: {Constitution}");
        Console.WriteLine($"                o==||====> Wisdom: {Wisdom}");
        Console.WriteLine($"                o==||====> Remaining health: {Health}/{StartingHealth}");
        Console.WriteLine($"O==|=====> *x*x** 0=|)==> **##** >-|)--> %%&&**|||||/// {TypeOfMonster.ToUpper()}\\\\\\||||| %%&&** <--(|-< **##** <==(|=0 *x*x** <=====|==O ");
    }
    
    public void RollToAttack(Character character)
    {
        TwentySidedDice d = new TwentySidedDice();
        int resultOfRoll = d.RollDice(1);
        int characterAC = character.ArmorClass;

        if (resultOfRoll >= characterAC)
        {
            Console.WriteLine($"The {TypeOfMonster} rolled a {resultOfRoll} against {character.Name}'s armor class {characterAC}");
            Console.WriteLine($"The {TypeOfMonster} is attacking {character.Name}");
            AttackCharacterWithWeapon(character, EquippedWeapon);
        }
        else
        {
            Console.WriteLine($"The {TypeOfMonster} rolled a {resultOfRoll} against {character.Name}'s armor class {characterAC}");
            Console.WriteLine($"The {TypeOfMonster}'s attempt to attack {character.Name} failed.");
        }
    }
    
    public void DealDamageTo(Character characterToDamage, int damage)
    {
        characterToDamage.TakeDamage(damage);
        Console.WriteLine($"{characterToDamage.Name} took {damage} points of damage.");
    }
    
    public void AttackCharacterWithWeapon(Character characterToAttack, Weapon attackWithWeapon)
    {
        Console.WriteLine($"The {TypeOfMonster} attacks {characterToAttack.Name} with {EquippedWeapon.TypeOfWeapon}");
        int damage = EquippedWeapon.DamageDice.RollDice(EquippedWeapon.NumberOfDamageRolls) + EquippedWeapon.DamageModifier;
        DealDamageTo(characterToAttack, damage);
    }
}