namespace TextBasedRPG.Weapons;

public class Weapon
{
    public Dice.Dice DamageDice { get; protected set; }
    public string TypeOfWeapon { get; protected set; }
    public int DamageModifier { get; protected set; }
    public int NumberOfDamageRolls { get; protected set; }
}